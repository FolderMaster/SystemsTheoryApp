using System.Drawing;

namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Интерфейс камеры.
    /// </summary>
    public interface ICamera
    {
        /// <summary>
        /// Возращает интерфейс сцены.
        /// </summary>
        IScene Scene { get; }

        /// <summary>
        /// Возращает изображение снимка.
        /// </summary>
        Image Shot { get; }
    }
}