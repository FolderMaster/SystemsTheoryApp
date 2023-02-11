using System.Windows.Forms;

namespace DecisionUnderUncertaintyApp.Views.Tabs
{
    public partial class ResultTab : UserControl
    {
        public double[] Array
        {
            set => DoubleArrayControl.Array = value;
        }

        public int Index
        {
            set => DoubleArrayControl.SetSelectedIndex(value);
        }

        public ResultTab()
        {
            InitializeComponent();
        }
    }
}