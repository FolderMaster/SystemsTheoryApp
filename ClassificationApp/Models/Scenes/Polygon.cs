using System;
using System.Collections.Generic;

namespace ClassificationApp.Models.Scenes
{
    public class Polygon : IShape
    {
        public object Tag { get; set; } = null;

        public List<Point> Points { get; set; } = new List<Point>();

        public Polygon()
        {
        }

        public Polygon(object tag)
        {
            Tag = tag;
        }

        public Polygon(List<Point> points)
        {
            Points = points;
        }

        public Polygon(object tag, List<Point> points)
        {
            Tag = tag;
            Points = points;
        }

        public IShape Display(IGraph graph)
        {
            throw new NotImplementedException();
        }

        public double GetMax(IGraph graph, int axisIndex)
        {
            throw new NotImplementedException();
        }

        public double GetMin(IGraph graph, int axisIndex)
        {
            throw new NotImplementedException();
        }
    }
}