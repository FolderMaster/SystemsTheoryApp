using System.Collections.Generic;

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
                for(int n = 0; n < point.AxisCount; ++n)
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
            for(int n = 0; n < point1.AxisCount && n < point2.AxisCount; ++n)
            {
                coordinates.Add(point2[n] - point1[n]);
            }
            return new Vector(coordinates);
        }

        public static Plane CreatePlaneByPoindAndVector(Point point, Vector vector)
        {
            Plane result = new Plane();
            result.A = vector[0];
            result.B = vector[1];
            result.C = vector[2];
            result.D = - vector[0] * point[0] - vector[1] * point[1] - vector[2] * point[2];
            return result;
        }
    }
}