using System;

namespace ClassificationApp.Models.Schedules
{
    public class Plane : IShape
    {
        public object Tag { get; set; } = null;

        public double A { get; } = 0;

        public double B { get; } = 0;

        public double C { get; } = 0;

        public double D { get; } = 0;

        public Plane()
        {
        }

        public Plane(object tag)
        {
            Tag = tag;
        }

        public IShape Display(ISchedule schedule)
        {
            return new Plane(Tag);
        }

        public double GetMax(ISchedule schedule, int axisIndex)
        {
            throw new NotImplementedException();
        }

        public double GetMin(ISchedule schedule, int axisIndex)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"({Tag})";
        }
    }
}