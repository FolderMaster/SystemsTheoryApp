using System.Collections.Generic;

namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Интерфейс сцен, У которых есть интерфейс графика, фигуры, интерфейс камеры.
    /// </summary>
    public interface IScene
    {
        /// <summary>
        /// Возращает и задаёт интерфейс графика.
        /// </summary>
        IGraph Graph { get; set; }

        /// <summary>
        /// Возращает и задаёт фигуры.
        /// </summary>
        List<IShape> Shapes { get; set; }

        /// <summary>
        /// Возращает и задаёт интерфейс камеры.
        /// </summary>
        ICamera Camera { get; set; }
    }
}