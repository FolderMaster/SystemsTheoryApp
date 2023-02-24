using System;

namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Класс логарифмического масштабирования.
    /// </summary>
    public class LogScale : IScale
    {
        public double Display(double value, double min, double max, double length) =>
            Math.Log10(value / min) / Math.Log10(max / min) * length;
    }
}