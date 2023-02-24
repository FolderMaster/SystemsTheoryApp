using System;
using System.Collections.Generic;

namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Класс многоугольника с точками.
    /// </summary>
    public class Polygon : IShape
    {
        public object Tag { get; set; } = null;

        /// <summary>
        /// Возращает и задаёт экземпляр точек.
        /// </summary>
        public List<Point> Points { get; set; } = new List<Point>();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Polygon"/> по умолчанию.
        /// </summary>
        public Polygon()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Polygon"/>.
        /// </summary>
        /// <param name="tag">Тег.</param>
        public Polygon(object tag)
        {
            Tag = tag;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Polygon"/>.
        /// </summary>
        /// <param name="points">Точки.</param>
        public Polygon(List<Point> points)
        {
            Points = points;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Polygon"/>.
        /// </summary>
        /// <param name="tag">Тег.</param>
        /// <param name="points">Точки.</param>
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