using System.ComponentModel;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Views.Forms
{
    public partial class PairComparisonCalculationForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PairComparisonMatrix PairComparisonMatrix
        {
            set => PairComparisonCalculationTab.PairComparisonMatrix = value;
        }

        public PairComparisonCalculationForm()
        {
            InitializeComponent();
        }
    }
}