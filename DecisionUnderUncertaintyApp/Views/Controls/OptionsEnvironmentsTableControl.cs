using System;
using System.ComponentModel;
using System.Windows.Forms;

using DecisionUnderUncertaintyApp.Models;

namespace DecisionUnderUncertaintyApp.Views.Controls
{
    public partial class OptionsEnvironmentsTableControl : UserControl
    {
        private OptionsEnvironmentsTable _optionsEnvironmentsTable = new
            OptionsEnvironmentsTable();

        private int _optionCount = 0;

        private int _environmentCount = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public OptionsEnvironmentsTable OptionsEnvironmentsTable
        {
            get => _optionsEnvironmentsTable;
            set
            {
                _optionsEnvironmentsTable = value;
                if (value != null)
                {
                    TableMatrix = value.TableMatrix;
                    IsLossTableCheckBox.Checked = value.IsLossTable;
                }
                else
                {
                    TableMatrix = new double[0, 0];
                    IsLossTableCheckBox.Checked = false;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[,] TableMatrix
        {
            get => DoubleMatrixControl.Matrix;
            set
            {
                DoubleMatrixControl.Matrix = value;
                OptionCount = TableMatrix.GetLength(0);
                EnvironmentCount = TableMatrix.GetLength(1);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int OptionCount
        {
            get => _optionCount;
            private set
            {
                _optionCount = value;
                OptionCountNumericUpDown.Value = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EnvironmentCount
        {
            get => _environmentCount;
            private set
            {
                _environmentCount = value;
                EnvironmentCountNumericUpDown.Value = value;
            }
        }

        public OptionsEnvironmentsTableControl()
        {
            InitializeComponent();
        }

        private void OptionCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _optionCount = (int)OptionCountNumericUpDown.Value;
        }

        private void EnvironmentCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _environmentCount = (int)EnvironmentCountNumericUpDown.Value;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TableMatrix = new double[_optionCount, _environmentCount];
        }

        private void IsLossTableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(OptionsEnvironmentsTable != null)
            {
                OptionsEnvironmentsTable.IsLossTable = IsLossTableCheckBox.Checked;
            }
        }

        private void DoubleMatrixControl_MatrixChanged(object sender, EventArgs e)
        {
            if (OptionsEnvironmentsTable != null)
            {
                OptionsEnvironmentsTable.TableMatrix = TableMatrix;
            }
        }
    }
}
