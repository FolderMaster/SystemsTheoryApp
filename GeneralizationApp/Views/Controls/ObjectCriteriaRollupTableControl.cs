using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Controls
{
    public partial class ObjectCriteriaRollupTableControl : UserControl
    {
        private int _objectCount = 1;

        private int _criteriaCount = 1;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[,] TableMatrix
        {
            get => ScoringTableGridControl.TableMatrix;
            set => ScoringTableGridControl.TableMatrix = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[] WeightMatrix
        {
            get => TableWeightsGridControl.TableMatrix;
            set => TableWeightsGridControl.TableMatrix = value;
        }

        public ObjectCriteriaRollupTableControl()
        {
            InitializeComponent();
        }

        private void ObjectCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _objectCount = (int)ObjectCountNumericUpDown.Value;
        }

        private void CriteriaCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _criteriaCount = (int)CriteriaCountNumericUpDown.Value;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TableMatrix = new double[_objectCount, _criteriaCount];
            WeightMatrix = new double[_criteriaCount];
        }
    }
}