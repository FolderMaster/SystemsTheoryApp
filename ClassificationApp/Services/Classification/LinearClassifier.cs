using System;
using System.Collections.Generic;

using ClassificationApp.Models.Countries;
using ClassificationApp.Models.Scenes;
using ClassificationApp.Services.Factories;

namespace ClassificationApp.Services.Classification
{
    /// <summary>
    /// Класс линейного классификатора с дополнительной информацией.
    /// </summary>
    public class LinearClassifier : IClassifier
    {
        public bool IsEducated { get; private set; } = false;

        /// <summary>
        /// Вектор плоскости.
        /// </summary>
        public Vector PlaneVector { get; private set; } = null;

        /// <summary>
        /// Точка плоскости.
        /// </summary>
        public Point PlanePoint { get; private set; } = null;

        /// <summary>
        /// Центральная точка развитых стран.
        /// </summary>
        public Point DevelopedMiddlePoint { get; private set; } = null;

        /// <summary>
        /// Центральная точка развивающихся стран.
        /// </summary>
        public Point DevelopingMiddlePoint { get; private set; } = null;

        /// <summary>
        /// Список точек обучающих стран.
        /// </summary>
        public List<Point> EduccationPoints { get; private set; } = new List<Point>();

        /// <summary>
        /// Список точек результирующих стран.
        /// </summary>
        public List<Point> ResultPoints { get; private set; } = new List<Point>();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="LinearClassifier"/> по умолчанию.
        /// </summary>
        public LinearClassifier()
        {
        }

        public void Educate(List<Country> list)
        {
            List<Point> developedPoints = new List<Point>();
            List<Point> developingPoints = new List<Point>();
            foreach (Country country in list)
            {
                if(country.Type == CountryType.Developing)
                {
                    developingPoints.Add(ShapeFactory.CreatePointByCountry(country));
                }
                else if(country.Type == CountryType.Developed)
                {
                    developedPoints.Add(ShapeFactory.CreatePointByCountry(country));
                }
            }

            EduccationPoints.AddRange(developedPoints);
            EduccationPoints.AddRange(developingPoints);

            DevelopedMiddlePoint = ShapeFactory.CreateMiddlePointByPoints(developedPoints);

            DevelopingMiddlePoint = ShapeFactory.CreateMiddlePointByPoints(developingPoints);

            PlanePoint = ShapeFactory.CreateMiddlePointByPoints(new List<Point>()
            { DevelopedMiddlePoint, DevelopingMiddlePoint });

            PlaneVector = ShapeFactory.CreateVectorByPoints(DevelopedMiddlePoint,
                DevelopingMiddlePoint);

            IsEducated = true;
        }

        public List<Country> Classify(List<Country> list)
        {
            if (!IsEducated)
            {
                throw new InvalidOperationException();
            }
            else
            {
                List<Country> result = new List<Country>();
                foreach (Country country in list)
                {
                    Point point = ShapeFactory.CreatePointByCountry(country);
                    Vector vector = ShapeFactory.CreateVectorByPoints(PlanePoint, point);

                    double character = Vector.CharacterOfAngleBetweenVectors(PlaneVector, vector);
                    Country newCountry = new Country(country);
                    if(character > 0)
                    {
                        newCountry.Type = CountryType.Developing;
                    }
                    else if(character < 0)
                    {
                        newCountry.Type = CountryType.Developed;
                    }
                    else
                    {
                        newCountry.Type = CountryType.None;
                    }
                    result.Add(newCountry);
                    ResultPoints.Add(ShapeFactory.CreatePointByCountry(newCountry));
                }
                return result;
            }
        }

        public override string ToString()
        {
            return "LinearClassifier";
        }
    }
}