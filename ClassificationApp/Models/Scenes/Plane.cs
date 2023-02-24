using System;

namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Класс поверхности с коэффициентами.
    /// </summary>
    public class Plane : IShape
    {
        public object Tag { get; set; } = null;

        /// <summary>
        /// Возращает и задаёт коэфициент A.
        /// </summary>
        public double A { get; set; } = 0;

        /// <summary>
        /// Возращает и задаёт коэфициент B.
        /// </summary>
        public double B { get; set; } = 0;

        /// <summary>
        /// Возращает и задаёт коэфициент C.
        /// </summary>
        public double C { get; set; } = 0;

        /// <summary>
        /// Возращает и задаёт коэфициент D.
        /// </summary>
        public double D { get; set; } = 0;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Plane"/> по умолчанию.
        /// </summary>
        public Plane()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Plane"/>.
        /// </summary>
        /// <param name="tag">Тег.</param>
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