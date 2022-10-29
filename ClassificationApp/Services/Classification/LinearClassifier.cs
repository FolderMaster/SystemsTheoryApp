using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassificationApp.Models.Countries;
using ClassificationApp.Models.Schedules;
using ClassificationApp.Services.Factories;

namespace ClassificationApp.Services.Classification
{
    public class LinearClassifier : IClassifier
    {
        private bool _isEducated = false;

        private Vector _vector = null;

        private Point _point = null;

        public bool IsEducated
        {
            get => _isEducated;
            private set => _isEducated = value;
        }

        public Vector Vector
        {
            get => _vector;
            private set => _vector = value;
        }

        public Point Point
        {
            get => _point;
            private set => _point = value;
        }

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

            Point developedMiddlePoint = ShapeFactory.CreateMiddlePointByPoints(developedPoints);

            Point developingMiddlePoint = ShapeFactory.CreateMiddlePointByPoints(developingPoints);

            Point = ShapeFactory.CreateMiddlePointByPoints(new List<Point>()
            { developedMiddlePoint, developingMiddlePoint });

            Vector = ShapeFactory.CreateVectorByPoints(developedMiddlePoint, developingMiddlePoint);

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
                    Vector vector = ShapeFactory.CreateVectorByPoints(Point, point);

                    double character = Vector.CharacterOfAngleBetweenVectors(Vector, vector);
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
                }
                return result;
            }
        }
    }
}