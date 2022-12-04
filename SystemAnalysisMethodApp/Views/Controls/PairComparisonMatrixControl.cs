using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Views.Controls
{
    public partial class PairComparisonMatrixControl : UserControl
    {
        private PairComparisonMatrix _pairComparisonMatrix = null;
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PairComparisonMatrix PairComparisonMatrix
        {
            get => _pairComparisonMatrix;
            set
            {
                _pairComparisonMatrix = value;
                DoubleMatrixGridControl.Matrix = value.Matrix;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string[] Names
        {
            get => DoubleMatrixGridControl.Names;
            set => DoubleMatrixGridControl.Names = value;
        }

        public PairComparisonMatrixControl()
        {
            InitializeComponent();
        }

        private void DoubleMatrixGridControl_MatrixChanged(object sender, EventArgs e)
        {
            string text = PairComparisonMatrix.IsRevisionNeeded ? $"Revision needed" : $"No revision needed";
            Label.Text = text;
        }
    }
}
