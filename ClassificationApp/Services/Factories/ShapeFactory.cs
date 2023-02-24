using System;
using System.Collections.Generic;
using System.Linq;
using ClassificationApp.Models.Countries;
using ClassificationApp.Models.Scenes;

namespace ClassificationApp.Services.Factories
{
    /// <summary>
    /// Класс фабрики фигур, представляющий методы для создания фигур.
    /// </summary>
    public static class ShapeFactory
    {
        /// <summary>
        /// Создаёт точку на основе страны.
        /// </summary>
        /// <param name="country">Страна.</param>
        /// <returns>Точка - представление страны.</returns>
        public static Point CreatePointByCountry(Country country)
        {
            return new Point(country.Type, new double[] { country.Gdp, country.Debt, 
                country.Density });
        }

        /// <summary>
        /// Создаёт центральную точку на основе списка точек.
        /// </summary>
        /// <param name="points">Список точек.</param>
        /// <returns>Центральная точка.</returns>
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

        /// <summary>
        /// Создаёт вектор на основе точек.
        /// </summary>
        /// <param name="point1">Первая точка - начало.</param>
        /// <param name="point2">Вторая точка - конец.</param>
        /// <returns>Вектор.</returns>
        public static Vector CreateVectorByPoints(Point point1, Point point2)
        {
            List<double> coordinates = new List<double>();
            for(int n = 0; n < point1.AxisCount && n < point2.AxisCount; ++n)
            {
                coordinates.Add(point2[n] - point1[n]);
            }
            return new Vector(coordinates);
        }

        /// <summary>
        /// Создаёт плоскость на основе точки и вектора.
        /// </summary>
        /// <param name="point">Точка.</param>
        /// <param name="vector">Вектор.</param>
        /// <returns>Плоскость.</returns>
        public static Plane CreatePlaneByPoindAndVector(Point point, Vector vector)
        {
            Plane result = new Plane();
            result.A = vector[0];
            result.B = vector[1];
            result.C = vector[2];
            result.D = - vector[0] * point[0] - vector[1] * point[1] - vector[2] * point[2];
            return result;
        }

        /// <summary>
        /// Создаёт орт на основе углов между осями.
        /// </summary>
        /// <param name="angles">Список углов между осями.</param>
        /// <returns>Орт.</returns>
        public static Vector CreateOrtByAngles(List<double> angles)
        {
            Vector result = new Vector();
            double angleSum = Math.Abs(angles[0]) + Math.Abs(angles[1]) + Math.Abs(angles[2]);
            if(angleSum != 0)
            {
                result.Coordinates = new List<double>
                {
                    angles[0] / angleSum,
                    angles[1] / angleSum,
                    angles[2] / angleSum
                };
            }
            else
            {
                result.Coordinates = new List<double> { 1, 1, 1 };
            }
            return result;
        }
    }
}