namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Интерфейс фигур, у которых есть тег, которые отображают фигуру в графике, находят
    /// минимальную и максимальную координату в оси.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Возращает и задаёт тег.
        /// </summary>
        object Tag { get; set; }

        /// <summary>
        /// Отображает фигуру в графике.
        /// </summary>
        /// <param name="graph">Интерфейс графика.</param>
        /// <returns>Отображение фигуры.</returns>
        IShape Display(IGraph graph);

        /// <summary>
        /// Находит минимальную координату в оси.
        /// </summary>
        /// <param name="graph">Интерфейс графика.</param>
        /// <param name="axisIndex">Индекс оси.</param>
        /// <returns>Минимальная координата в оси.</returns>
        double GetMax(IGraph graph, int axisIndex);

        /// <summary>
        /// Находит максимальную координату в оси.
        /// </summary>
        /// <param name="graph">Интерфейс графика.</param>
        /// <param name="axisIndex">Индекс оси.</param>
        /// <returns>Максимальная координата в оси.</returns>
        double GetMin(IGraph graph, int axisIndex);
    }
}