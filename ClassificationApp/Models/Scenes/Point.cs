using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Класс точки с координатами.
    /// </summary>
    public class Point : IShape, IComparable
    {
        public object Tag { get; set; } = null;

        /// <summary>
        /// Возращает и задаёт координаты.
        /// </summary>
        public List<double> Coordinates { get; set; } = new List<double>();

        /// <summary>
        /// Возращает количество осей.
        /// </summary>
        public int AxisCount
        {
            get => Coordinates.Count;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point"/> по умолчанию.
        /// </summary>
        public Point()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point"/>.
        /// </summary>
        /// <param name="tag">Тег.</param>
        public Point(object tag)
        {
            Tag = tag;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point"/>.
        /// </summary>
        /// <param name="coordinates">Координаты.</param>
        public Point(IEnumerable<double> coordinates)
        {
            Coordinates = coordinates.ToList();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point"/>.
        /// </summary>
        /// <param name="tag">Тег.</param>
        /// <param name="coordinates">Координаты.</param>
        public Point(object tag, IEnumerable<double> coordinates)
        {
            Tag = tag;
            Coordinates = coordinates.ToList();
        }

        /// <summary>
        /// Возращает и задаёт координату.
        /// </summary>
        /// <param name="index">Индекс оси.</param>
        /// <returns>Координата по индексу оси.</returns>
        public double this[int index]
        {
            get => Coordinates[index];
            set => Coordinates[index] = value;
        }

        /// <summary>
        /// Рассчитывает расстояние между точками.
        /// </summary>
        /// <param name="point">Точка.</param>
        /// <param name="schedule">График.</param>
        /// <returns>Расстояние между точками.</returns>
        public double GetDistance(Point point, IGraph schedule)
        {
            double result = 0;
            for (int n = 0; n < point.AxisCount || n < AxisCount; ++n)
            {
                double coordinate1 = n < AxisCount ? this[n] : schedule.DefaultValue;
                double coordinate2 = n < point.AxisCount ? point[n] : schedule.DefaultValue;

                result += Math.Pow(coordinate2 - coordinate1, 2);
            }
            return Math.Sqrt(result);
        }

        /// <summary>
        /// Рассчитывает расстояние между точками.
        /// </summary>
        /// <param name="point">Точка.</param>
        /// <returns>Расстояние между точками.</returns>
        public double GetDistance(Point point)
        {
            double result = 0;
            for (int n = 0; n < point.AxisCount && n < AxisCount; ++n)
            {
                double coordinate1 = n < AxisCount ? this[n] : 0;
                double coordinate2 = n < point.AxisCount ? point[n] : 0;

                result += Math.Pow(coordinate2 - coordinate1, 2);
            }
            return Math.Sqrt(result);
        }

        public IShape Display(IGraph schedule)
        {
            List<double> coordinates = new List<double>();
            for (int n = 0; n < schedule.Axises.Count; ++n)
            {
                if (n < AxisCount)
                {
                    coordinates.Add(schedule.Axises[n].Display(this[n]));
                }
                else
                {
                    coordinates.Add(schedule.DefaultValue);
                }
            }
            return new Point(Tag, coordinates);
        }

        public double GetMax(IGraph schedule, int axisIndex)
        {
            return axisIndex < AxisCount ? this[axisIndex] : schedule.DefaultValue;
        }

        public double GetMin(IGraph schedule, int axisIndex)
        {
            return axisIndex < AxisCount ? this[axisIndex] : schedule.DefaultValue;
        }

        public override string ToString()
        {
            return string.Join(";", Coordinates) + $" ({Tag})";
        }

        public int CompareTo(object obj)
        {
            if (obj is Point point)
            {
                for (int n = 0; n < point.AxisCount && n < AxisCount; ++n)
                {
                    if (point[n] < this[n])
                    {
                        return 1;
                    }
                    else if (point[n] > this[n])
                    {
                        return -1;
                    }
                }
                if (point.AxisCount < AxisCount)
                {
                    return 1;
                }
                else if (point.AxisCount < AxisCount)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Перемещает точку вектором.
        /// </summary>
        /// <param name="vector">Вектор.</param>
        /// <returns>Точка, перемещённая по вектору.</returns>
        public Point MoveByVector(Vector vector)
        {
            List<double> coordinates = new List<double>();
            for (int n = 0; n < AxisCount && n < vector.AxisCount; ++n)
            {
                coordinates.Add(this[n] + vector[n]);
            }
            return new Point(coordinates);
        }
    }
}