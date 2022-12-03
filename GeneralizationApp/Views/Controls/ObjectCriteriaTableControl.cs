using System;
using System.ComponentModel;
using System.Windows.Forms;

using GeneralizationApp.Models;

namespace GeneralizationApp.Views.Controls
{
    public partial class ObjectCriteriaTableControl : UserControl
    {
        private bool _withWeights = false;

        private int _objectCount = 0;

        private int _criteriaCount = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ObjectCriteriaTable ObjectCriteriaRollupTable
        {
            get => new ObjectCriteriaTable(TableMatrix, WithWeights ? WeightMatrix : null, 
                DecreasingMatrix);
            set
            {
                if (value != null)
                {
                    TableMatrix = value.TableMatrix;
                    DecreasingMatrix = value.DecreasingMatrix;
                    if (value.WeightMatrix != null)
                    {
                        WeightMatrix = value.WeightMatrix;
                        WithWeights = true;
                    }
                    else
                    {
                        WeightMatrix = new double[CriteriaCount];
                        WithWeights = false;
                    }
                }
                else
                {
                    TableMatrix = new double[0, 0];
                    WeightMatrix = new double[0];
                    DecreasingMatrix = new bool[0];
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
                ObjectCount = TableMatrix.GetLength(0);
                CriteriaCount = TableMatrix.GetLength(1);
            }
        }

        public bool WithWeights
        {
            get => _withWeights;
            set
            {
                WithWeightsCheckBox.Checked = _withWeights = value;
                if (_withWeights)
                {
                    WeightTableGridControl.Visible = true;
                }
                else
                {
                    WeightTableGridControl.Visible = false;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[] WeightMatrix
        {
            get => WeightTableGridControl.TableMatrix;
            set => WeightTableGridControl.TableMatrix = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool[] DecreasingMatrix
        {
            get => DecreasingCriteriaTableGridControl.TableMatrix;
            set => DecreasingCriteriaTableGridControl.TableMatrix = value;
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CriteriaCount
        {
            get => _criteriaCount;
            private set
            {
                _criteriaCount = value;
                CriteriaCountNumericUpDown.Value = value;
            }
        }

        public ObjectCriteriaTableControl()
        {
            InitializeComponent();
        }

        private void ObjectCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ObjectCount = (int)ObjectCountNumericUpDown.Value;
        }

        private void CriteriaCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CriteriaCount = (int)CriteriaCountNumericUpDown.Value;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TableMatrix = new double[ObjectCount, CriteriaCount];
            WeightMatrix = new double[CriteriaCount];
            DecreasingMatrix = new bool[CriteriaCount];
        }

        private void WithWeightsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WithWeights = WithWeightsCheckBox.Checked;
        }
    }
}