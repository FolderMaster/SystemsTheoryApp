using System;
using System.Collections.Generic;
using System.Linq;

using ClassificationApp.Models.Countries;
using ClassificationApp.Models.Schedules;
using ClassificationApp.Services.Factories;

namespace ClassificationApp.Services.Classification
{
    public class NeighborClassifier : IClassifier
    {
        private bool _isEducated = false;

        private List<Point> _points = new List<Point>();

        public List<Point> Points
        {
            get => _points;
            private set => _points = value;
        }

        public bool IsEducated
        {
            get => _isEducated;
            private set => _isEducated = value;
        }

        public int NeighborsCount { get; set; } = 1;

        public NeighborClassifier()
        {
        }

        public NeighborClassifier(int neighborsCount)
        {
            NeighborsCount = neighborsCount;
        }

        public void Educate(List<Country> list)
        {
            foreach(Country country in list)
            {
                Points.Add(ShapeFactory.CreatePointByCountry(country));
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
                    for(int h = 0; h < Points.Count; ++h)
                    {
                        distances.Add((points[n].GetDistance(Points[h]), h));
                    }

                    int developingsCount = 0;
                    int developedsCount = 0;
                    for (int i = 0; i < NeighborsCount; ++i)
                    {
                        double min = distances.Select(a => a.Item1).Min();
                        (double, int) distance = distances.First(a => a.Item1 == min);

                        Point point = Points[distance.Item2];
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
                }
                return result;
            }
        }
    }
}