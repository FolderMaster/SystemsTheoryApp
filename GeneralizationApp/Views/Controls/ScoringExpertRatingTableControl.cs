using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Controls
{
    public partial class ScoringExpertRatingTableControl : UserControl
    {
        private bool _withCompetencies = false;

        private int _expertCount = 1;

        private int _objectCount = 1;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[,] TableMatrix
        {
            get => ScoringTableGridControl.TableMatrix;
            set => ScoringTableGridControl.TableMatrix = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool WithCompetencies
        {
            get => _withCompetencies;
            set
            {
                WithCompetenciesCheckBox.Checked = _withCompetencies = value;
                if (_withCompetencies)
                {
                    TableWeightsGridControl.Visible = true;
                }
                else
                {
                    TableWeightsGridControl.Visible = false;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[] WeightMatrix
        {
            get => TableWeightsGridControl.TableMatrix;
            set => TableWeightsGridControl.TableMatrix = value;
        }

        public ScoringExpertRatingTableControl()
        {
            InitializeComponent();
        }

        private void ExpertCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _expertCount = (int)ExpertCountNumericUpDown.Value;
        }

        private void ObjectCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _objectCount = (int)ObjectCountNumericUpDown.Value;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TableMatrix = new double[_expertCount, _objectCount];
            WeightMatrix = new double[_expertCount];
        }

        private void WithCompetenciesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WithCompetencies = WithCompetenciesCheckBox.Checked;
        }
    }
}