namespace DecisionUnderUncertaintyApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для редактирования элементов массива вещественных чисел.
    /// </summary>
    public partial class DoubleArrayControl : ArrayControl<double>
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="DoubleArrayControl"/> по умолчанию.
        /// </summary>
        public DoubleArrayControl()
        {
            InitializeComponent();
        }

        protected override double Parse(string text) => double.Parse(text);
    }
}