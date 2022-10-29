using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassificationApp.Models.Schedules
{
    public class Point : IShape, IComparable
    {
        public object Tag { get; set; } = null;

        public List<double> Coordinates { get; set; } = new List<double>();

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

        public double GetDistance(Point point, ISchedule schedule)
        {
            double result = 0;
            for (int n = 0; n < point.Coordinates.Count || n < Coordinates.Count; ++n)
            {
                double coordinate1 = n < Coordinates.Count ? Coordinates[n] :
                    schedule.DefaultValue;
                double coordinate2 = n < point.Coordinates.Count ? point.Coordinates[n] :
                    schedule.DefaultValue;

                result += Math.Pow(coordinate2 - coordinate1, 2);
            }
            return Math.Sqrt(result);
        }

        public double GetDistance(Point point)
        {
            double result = 0;
            for (int n = 0; n < point.Coordinates.Count && n < Coordinates.Count; ++n)
            {
                double coordinate1 = Coordinates[n];
                double coordinate2 = point.Coordinates[n];

                result += Math.Pow(coordinate2 - coordinate1, 2);
            }
            return Math.Sqrt(result);
        }

        public IShape Display(ISchedule schedule)
        {
            List<double> coordinates = new List<double>();
            for (int n = 0; n < schedule.Axises.Count; ++n)
            {
                if (n < Coordinates.Count)
                {
                    coordinates.Add(schedule.Axises[n].Display(Coordinates[n]));
                }
                else
                {
                    coordinates.Add(schedule.DefaultValue);
                }
            }
            return new Point(Tag, coordinates);
        }

        public double GetMax(ISchedule schedule, int axisIndex)
        {
            return axisIndex < Coordinates.Count ? Coordinates[axisIndex] : schedule.DefaultValue;
        }

        public double GetMin(ISchedule schedule, int axisIndex)
        {
            return axisIndex < Coordinates.Count ? Coordinates[axisIndex] : schedule.DefaultValue;
        }

        public override string ToString()
        {
            return string.Join(";", Coordinates) + $" ({Tag})";
        }

        public int CompareTo(object obj)
        {
            if (obj is Point point)
            {
                List<double> coordinates = point.Coordinates;
                for (int n = 0; n < coordinates.Count && n < Coordinates.Count; ++n)
                {
                    if (coordinates[n] < Coordinates[n])
                    {
                        return 1;
                    }
                    else if (coordinates[n] > Coordinates[n])
                    {
                        return -1;
                    }
                }
                if (coordinates.Count < Coordinates.Count)
                {
                    return 1;
                }
                else if (coordinates.Count < Coordinates.Count)
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
    }
}