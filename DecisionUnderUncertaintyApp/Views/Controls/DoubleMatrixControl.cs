namespace DecisionUnderUncertaintyApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для редактирования элементов матрицы вещественных чисел.
    /// </summary>
    public partial class DoubleMatrixControl : MatrixControl<double>
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="DoubleMatrixControl"/> по умолчанию.
        /// </summary>
        public DoubleMatrixControl()
        {
            InitializeComponent();
        }

        protected override double Parse(string text) => double.Parse(text);
    }
}