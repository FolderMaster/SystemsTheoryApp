using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassificationApp.Models.Scenes
{
    public class Point : IShape, IComparable
    {
        public object Tag { get; set; } = null;

        public List<double> Coordinates { get; set; } = new List<double>();

        public int AxisCount
        {
            get => Coordinates.Count;
        }

        public Point()
        {
        }

        public Point(object tag)
        {
            Tag = tag;
        }

        public Point(IEnumerable<double> coordinates)
        {
            Coordinates = coordinates.ToList();
        }

        public Point(object tag, IEnumerable<double> coordinates)
        {
            Tag = tag;
            Coordinates = coordinates.ToList();
        }

        public double this[int index]
        {
            get => Coordinates[index];
            set => Coordinates[index] = value;
        }

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