using System.Drawing;

namespace DecisionUnderUncertaintyApp.Views
{
    /// <summary>
    /// Класс менеджер цветов, предоставляющий свойства цветов.
    /// </summary>
    public static class ColorManager
    {
        /// <summary>
        /// Возращает цвет корректной обработки.
        /// </summary>
        public static Color CorrectColor { get; } = Color.White;

        /// <summary>
        /// Возращает цвет ошибки при обработке.
        /// </summary>
        public static Color ErrorColor { get; } = Color.Pink;

        /// <summary>
        /// Возращает цвет ответа.
        /// </summary>
        public static Color AnswerColor { get; } = Color.LightGreen;

        /// <summary>
        /// Возращает цвет выбранного ответа.
        /// </summary>
        public static Color SelectedAnswerColor { get; } = Color.Green;
    }
}