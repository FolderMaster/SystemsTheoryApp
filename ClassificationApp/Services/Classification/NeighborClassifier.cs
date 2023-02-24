using System;
using System.Collections.Generic;
using System.Linq;

using ClassificationApp.Models.Countries;
using ClassificationApp.Models.Scenes;
using ClassificationApp.Services.Factories;

namespace ClassificationApp.Services.Classification
{
    /// <summary>
    /// Класс классификатора метода ближайщего соседа с дополнительной информацией.
    /// </summary>
    public class NeighborClassifier : IClassifier
    {
        public bool IsEducated { get; private set; } = false;

        /// <summary>
        /// Список точек обучающих стран.
        /// </summary>
        public List<Point> EduccationPoints { get; private set; } = new List<Point>();

        /// <summary>
        /// Список точек результирующих стран.
        /// </summary>
        public List<Point> ResultPoints { get; private set; } = new List<Point>();

        /// <summary>
        /// Возращает и задаёт количество соседей.
        /// </summary>
        public int NeighborsCount { get; set; } = 1;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="NeighborClassifier"/> по умолчанию.
        /// </summary>
        public NeighborClassifier()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="NeighborClassifier"/>.
        /// </summary>
        /// <param name="neighborsCount">Количество соседей.</param>
        public NeighborClassifier(int neighborsCount)
        {
            NeighborsCount = neighborsCount;
        }

        public void Educate(List<Country> list)
        {
            foreach(Country country in list)
            {
                EduccationPoints.Add(ShapeFactory.CreatePointByCountry(country));
            }
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
                List<Point> points = new List<Point>();
                foreach(Country country in list)
                {
                    points.Add(ShapeFactory.CreatePointByCountry(country));
                }
                for(int n = 0; n < points.Count; n++)
                {
                    List<(double, int)> distances = new List<(double, int)>();
                    for(int h = 0; h < EduccationPoints.Count; ++h)
                    {
                        distances.Add((points[n].GetDistance(EduccationPoints[h]), h));
                    }

                    int developingsCount = 0;
                    int developedsCount = 0;
                    for (int i = 0; i < NeighborsCount; ++i)
                    {
                        double min = distances.Select(a => a.Item1).Min();
                        (double, int) distance = distances.First(a => a.Item1 == min);

                        Point point = EduccationPoints[distance.Item2];
                        if ((CountryType)point.Tag == CountryType.Developed)
                        {
                            ++developedsCount;
                        }
                        else if((CountryType)point.Tag == CountryType.Developing)
                        {
                            ++developingsCount;
                        }
                        distances.Remove(distance);
                    }
                    
                    Country country = new Country(list[n]);
                    if (developedsCount > developingsCount)
                    {
                        country.Type = CountryType.Developed;
                    }
                    else if(developingsCount > developedsCount)
                    {
                        country.Type = CountryType.Developing;
                    }
                    else
                    {
                        country.Type = CountryType.None;
                    }
                    result.Add(country);
                    ResultPoints.Add(ShapeFactory.CreatePointByCountry(country));
                }
                return result;
            }
        }

        public override string ToString()
        {
            return $"NeighborClassifier (NeighborsCount = {NeighborsCount})";
        }
    }
}