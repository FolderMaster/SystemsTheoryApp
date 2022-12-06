using System;
using System.ComponentModel;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Views.Tabs
{
    public partial class PairComparisonTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PairComparisonMatrix PairComparisonMatrix
        {
            get => PairComparisonMatrixControl.PairComparisonMatrix;
            set => PairComparisonMatrixControl.PairComparisonMatrix = value;
        }

        public PairComparisonTab()
        {
            InitializeComponent();
        }

        private void PairComparisonMatrixControl_PairComparisonMatrixChanged(object sender, 
            EventArgs e)
        {
            if(PairComparisonMatrixControl.IsRevisionNeeded)
            {
                OKButton.Enabled = false;
            }
            else
            {
                OKButton.Enabled = true;
            }
        }
    }
}