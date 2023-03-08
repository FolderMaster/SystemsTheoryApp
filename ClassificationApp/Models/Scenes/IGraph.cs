using System.Collections.Generic;

namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Интерфейс графиков, у которых есть оси, фигуры, отображения фигур, камера по умолчанию,
    /// значение по умолчанию, которые находят минимальные и максимальные координаты на оси и
    /// выполняют отображение фигур по умолчанию.
    /// </summary>
    public interface IGraph
    {
        /// <summary>
        /// Возращает оси.
        /// </summary>
        List<Axis> Axises { get; }

        /// <summary>
        /// Возращает и задаёт фигуры.
        /// </summary>
        List<IShape> Shapes { get; set; }

        /// <summary>
        /// Возращает отображения фигур.
        /// </summary>
        List<IShape> Displays { get; }

        /// <summary>
        /// Возращает камеру по умолчанию.
        /// </summary>
        ICamera DefaultCamera { get; }

        /// <summary>
        /// Возращает и задаёт значение по умолчанию.
        /// </summary>
        double DefaultValue { get; set; }

        /// <summary>
        /// Находит минимальную координату на оси.
        /// </summary>
        /// <param name="axisesIndex">Индекс оси.</param>
        /// <returns>Минимальная координата на оси.</returns>
        double GetMin(int axisesIndex);

        /// <summary>
        /// Находит максимальную координату на оси.
        /// </summary>
        /// <param name="axisesIndex">Индекс оси.</param>
        /// <returns>Максимальная координата на оси.</returns>
        double GetMax(int axisesIndex);

        /// <summary>
        /// Выполнить отображение фигур по умолчанию.
        /// </summary>
        void DefaultDisplay();
    }
}