using System.ComponentModel;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Views.Forms
{
    public partial class PairComparisonForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PairComparisonMatrix PairComparisonMatrix
        {
            get => PairComparisonTab.PairComparisonMatrix;
            set => PairComparisonTab.PairComparisonMatrix = value;
        }

        public PairComparisonForm()
        {
            InitializeComponent();
        }
    }
}
