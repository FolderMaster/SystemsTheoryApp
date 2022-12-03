using System;
using System.ComponentModel;
using System.Windows.Forms;

using GeneralizationApp.Models;

namespace GeneralizationApp.Views.Controls
{
    public partial class ScoringExpertRatingTableControl : UserControl
    {
        private bool _withCompetencies = false;

        private int _expertCount = 0;

        private int _objectCount = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ScoringExpertRatingTable ScoringExpertRatingTable
        {
            get => new ScoringExpertRatingTable(TableMatrix, WithCompetencies ? CompetenceMatrix : 
                null);
            set
            {
                if (value != null)
                {
                    TableMatrix = value.TableMatrix;
                    if(value.CompetenceMatrix != null)
                    {
                        CompetenceMatrix = value.CompetenceMatrix;
                        WithCompetencies = true;
                    }
                    else
                    {
                        CompetenceMatrix = new double[ExpertCount];
                        WithCompetencies = false;
                    }
                }
                else
                {
                    TableMatrix = new double[0, 0];
                    CompetenceMatrix = new double[0];
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[,] TableMatrix
        {
            get => ScoringTableGridControl.TableMatrix;
            set
            {
                ScoringTableGridControl.TableMatrix = value;
                ExpertCount = TableMatrix.GetLength(0);
                ObjectCount = TableMatrix.GetLength(1);
            }
        }

        public bool WithCompetencies
        {
            get => _withCompetencies;
            set
            {
                WithCompetenciesCheckBox.Checked = _withCompetencies = value;
                if (_withCompetencies)
                {
                    CompetenceTableGridControl.Visible = true;
                }
                else
                {
                    CompetenceTableGridControl.Visible = false;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[] CompetenceMatrix
        {
            get => CompetenceTableGridControl.TableMatrix;
            set => CompetenceTableGridControl.TableMatrix = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ExpertCount
        {
            get => _expertCount;
            private set
            {
                _expertCount = value;
                ExpertCountNumericUpDown.Value = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ObjectCount
        {
            get => _objectCount;
            private set
            {
                _objectCount = value;
                ObjectCountNumericUpDown.Value = value;
            }
        }

        public ScoringExpertRatingTableControl()
        {
            InitializeComponent();
        }

        private void ExpertCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ExpertCount = (int)ExpertCountNumericUpDown.Value;
        }

        private void ObjectCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ObjectCount = (int)ObjectCountNumericUpDown.Value;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TableMatrix = new double[ExpertCount, ObjectCount];
            CompetenceMatrix = new double[ExpertCount];
        }

        private void WithCompetenciesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WithCompetencies = WithCompetenciesCheckBox.Checked;
        }
    }
}