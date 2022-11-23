using System;

namespace ClassificationApp.Models.Scenes
{
    public class Plane : IShape
    {
        public object Tag { get; set; } = null;

        public double A { get; set; } = 0;

        public double B { get; set; } = 0;

        public double C { get; set; } = 0;

        public double D { get; set; } = 0;

        public Plane()
        {
        }

        public Plane(object tag)
        {
            Tag = tag;
        }

        public IShape Display(IGraph schedule)
        {
            return new Plane(Tag);
        }

        public double GetMax(IGraph schedule, int axisIndex)
        {
            return 0;
        }

        public double GetMin(IGraph schedule, int axisIndex)
        {
            return 0;
        }

        public override string ToString()
        {
            return $"({Tag})";
        }
    }
}