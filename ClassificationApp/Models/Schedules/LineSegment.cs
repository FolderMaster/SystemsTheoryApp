﻿namespace ClassificationApp.Models.Schedules
{
    public class LineSegment : IShape
    {
        public Point Begin { get; set; } = new Point();

        public Point End { get; set; } = new Point();

        public LineSegment()
        {
        }

        public LineSegment(Point begin, Point end)
        {
            Begin = begin;
            End = end;
        }

        public IShape Display(ISchedule schedule)
        {
            Point begin = new Point();
            Point end = new Point();

            for (int n = 0; n < schedule.Axises.Count; ++n)
            {
                if (n < Begin.Coordinates.Count)
                {
                    begin.Coordinates.Add(schedule.Axises[n].Display(Begin.Coordinates[n]));
                }
                else
                {
                    begin.Coordinates.Add(schedule.DefaultValue);
                }

                if (n < End.Coordinates.Count)
                {
                    end.Coordinates.Add(schedule.Axises[n].Display(End.Coordinates[n]));
                }
                else
                {
                    end.Coordinates.Add(schedule.DefaultValue);
                }
            }
            return new LineSegment(begin, end);
        }

        public double GetMax(ISchedule schedule, int axisIndex)
        {
            double begin = axisIndex < Begin.Coordinates.Count ? Begin.Coordinates[axisIndex] :
                schedule.DefaultValue;
            double end = axisIndex < End.Coordinates.Count ? End.Coordinates[axisIndex] :
                schedule.DefaultValue;
            return begin > end ? begin : end;
        }

        public double GetMin(ISchedule schedule, int axisIndex)
        {
            double begin = axisIndex < Begin.Coordinates.Count ? Begin.Coordinates[axisIndex] :
                schedule.DefaultValue;
            double end = axisIndex < End.Coordinates.Count ? End.Coordinates[axisIndex] :
                schedule.DefaultValue;
            return begin < end ? begin : end;
        }

        public override string ToString()
        {
            return $"{Begin}\t{End}";
        }
    }
}