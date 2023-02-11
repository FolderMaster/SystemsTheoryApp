namespace DecisionUnderUncertaintyApp.Views.Controls
{
    public partial class DoubleMatrixControl : MatrixControl<double>
    {
        public DoubleMatrixControl()
        {
            InitializeComponent();
        }

        protected override double Parse(string text) => double.Parse(text);
    }
}