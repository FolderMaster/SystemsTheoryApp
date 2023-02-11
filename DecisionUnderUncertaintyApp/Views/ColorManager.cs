using System.Drawing;

namespace DecisionUnderUncertaintyApp.Views
{
    public static class ColorManager
    {
        public static Color CorrectColor { get; } = Color.White;

        public static Color ErrorColor { get; } = Color.Pink;

        public static Color AnswerColor { get; } = Color.LightGreen;

        public static Color SelectedAnswerColor { get; } = Color.Green;
    }
}