using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassificationApp.Models.Countries;
using ClassificationApp.Models.Scenes;

namespace ClassificationApp.Services.Factories
{
    public static class ShapeFactory
    {
        public static Point CreatePointByCountry(Country country)
        {
            return new Point(country.Type, new double[] { country.Gdp, country.Debt, 
                country.Density });
        }

        public static Point CreateMiddlePointByPoints(List<Point> points)
        {
            List<double> coordinates = new List<double>();
            foreach(Point point in points)
            {
                for(int n = 0; n < point.Coordinates.Count; ++n)
                {
                    if(n >= coordinates.Count)
                    {
                        coordinates.Add(0);
                    }
                    coordinates[n] += point.Coordinates[n];
                }
            }
            for(int n = 0; n < coordinates.Count; ++n)
            {
                coordinates[n] /= points.Count;
            }
            return new Point(coordinates);
        }

        public static Vector CreateVectorByPoints(Point point1, Point point2)
        {
            List<double> coordinates = new List<double>();
            for(int n = 0; n < point1.Coordinates.Count && n < point2.Coordinates.Count; ++n)
            {
                coordinates.Add(point2.Coordinates[n] - point1.Coordinates[n]);
            }
            return new Vector(coordinates);
        }

        public static Plane CreatePlaneByPoindAndVector(Point point, Vector vector)
        {
            Plane result = new Plane();
            result.A = vector.Coordinates[0];
            result.B = vector.Coordinates[1];
            result.C = vector.Coordinates[2];
            result.D = - vector.Coordinates[0] * point.Coordinates[0] - vector.Coordinates[1]
                * point.Coordinates[1] - vector.Coordinates[2] * point.Coordinates[2];
            return result;
        }
    }
}