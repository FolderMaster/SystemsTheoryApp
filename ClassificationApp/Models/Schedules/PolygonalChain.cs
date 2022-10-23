using System.Collections.Generic;
using System.Linq;

namespace ClassificationApp.Models.Schedules
{
    public class PolygonalChain : IShape
    {
        public List<Point> Points { get; set; } = new List<Point>();

        public PolygonalChain()
        {
        }

        public PolygonalChain(IEnumerable<Point> points)
        {
            Points = points.ToList();
        }

        public IShape Display(ISchedule schedule)
        {
            List<Point> points = new List<Point>();
            foreach (Point point in Points)
            {
                Point newPoint = new Point();
                for (int a = 0; a < schedule.Axises.Count; ++a)
                {
                    if (a < point.Coordinates.Count)
                    {
                        newPoint.Coordinates.Add(schedule.Axises[a].Display(point.Coordinates[a]));
                    }
                    else
                    {
                        newPoint.Coordinates.Add(schedule.DefaultValue);
                    }
                }
                points.Add(newPoint);
            }
            return new PolygonalChain(points);
        }

        public double GetMax(ISchedule schedule, int axisIndex)
        {
            List<double> coordinates = new List<double>();
            for (int p = 0; p < Points.Count; ++p)
            {
                if (axisIndex < Points.Count)
                {
                    coordinates.Add(Points[p].Coordinates[axisIndex]);
                }
                else
                {
                    coordinates.Add(schedule.DefaultValue);
                }
            }
            return coordinates.Max();
        }

        public double GetMin(ISchedule schedule, int axisIndex)
        {
            List<double> coordinates = new List<double>();
            for (int p = 0; p < Points.Count; ++p)
            {
                if (axisIndex < Points.Count)
                {
                    coordinates.Add(Points[p].Coordinates[axisIndex]);
                }
                else
                {
                    coordinates.Add(schedule.DefaultValue);
                }
            }
            return coordinates.Min();
        }

        public override string ToString()
        { 
            return string.Join("\t", Points);
        }
    }
}