namespace DecisionUnderUncertaintyApp.Views.Controls
{
    public partial class DoubleArrayControl : ArrayControl<double>
    {
        public DoubleArrayControl()
        {
            InitializeComponent();
        }

        protected override double Parse(string text) => double.Parse(text);
    }
}