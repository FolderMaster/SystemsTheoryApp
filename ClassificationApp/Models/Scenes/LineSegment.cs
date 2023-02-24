namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Класс отрезка с начальной и конечной точками.
    /// </summary>
    public class LineSegment : IShape
    {
        public object Tag { get; set; } = null;

        /// <summary>
        /// Возращает и задаёт точку начала.
        /// </summary>
        public Point Begin { get; set; } = new Point();

        /// <summary>
        /// Возращает и задаёт точку конца.
        /// </summary>
        public Point End { get; set; } = new Point();

        /// <summary>
        /// Создаёт экземлпяр класса <see cref="LineSegment"/> по умолчанию.
        /// </summary>
        public LineSegment()
        {
        }

        /// <summary>
        /// Создаёт экземлпяр класса <see cref="LineSegment"/>.
        /// </summary>
        /// <param name="tag">Тег.</param>
        public LineSegment(object tag)
        {
            Tag = tag;
        }

        /// <summary>
        /// Создаёт экземлпяр класса <see cref="LineSegment"/>.
        /// </summary>
        /// <param name="begin">Точка начала.</param>
        /// <param name="end">Точка конца.</param>
        public LineSegment(Point begin, Point end)
        {
            Begin = begin;
            End = end;
        }

        /// <summary>
        /// Создаёт экземлпяр класса <see cref="LineSegment"/>.
        /// </summary>
        /// <param name="tag">Тег.</param>
        /// <param name="begin">Точка начала.</param>
        /// <param name="end">Точка конца.</param>
        public LineSegment(object tag, Point begin, Point end)
        {
            Tag = tag;
            Begin = begin;
            End = end;
        }

        public IShape Display(IGraph schedule)
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
            return new LineSegment(Tag, begin, end);
        }

        public double GetMax(IGraph schedule, int axisIndex)
        {
            double begin = axisIndex < Begin.Coordinates.Count ? Begin.Coordinates[axisIndex] :
                schedule.DefaultValue;
            double end = axisIndex < End.Coordinates.Count ? End.Coordinates[axisIndex] :
                schedule.DefaultValue;
            return begin > end ? begin : end;
        }

        public double GetMin(IGraph schedule, int axisIndex)
        {
            double begin = axisIndex < Begin.Coordinates.Count ? Begin.Coordinates[axisIndex] :
                schedule.DefaultValue;
            double end = axisIndex < End.Coordinates.Count ? End.Coordinates[axisIndex] :
                schedule.DefaultValue;
            return begin < end ? begin : end;
        }

        public override string ToString()
        {
            return $"{Begin}-{End} ({Tag})";
        }
    }
}