namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Интерфейс масштабирований, которые производят отображение координат.
    /// </summary>
    public interface IScale
    {
        /// <summary>
        /// Производит отображение координаты.
        /// </summary>
        /// <param name="value">Координата.</param>
        /// <param name="min">Минимум.</param>
        /// <param name="max">Максимум.</param>
        /// <param name="length">Длина оси.</param>
        /// <returns>Отображенная координата.</returns>
        double Display(double value, double min, double max, double length);
    }
}