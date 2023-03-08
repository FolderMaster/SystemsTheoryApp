using System;
using System.ComponentModel;
using System.Windows.Forms;

using DecisionUnderUncertaintyApp.Models;

namespace DecisionUnderUncertaintyApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для редактирования таблицы вариантов и состояний среды.
    /// </summary>
    public partial class OptionsEnvironmentsTableControl : UserControl
    {
        /// <summary>
        /// Таблица вариантов и состояний среды.
        /// </summary>
        private OptionsEnvironmentsTable _optionsEnvironmentsTable = new
            OptionsEnvironmentsTable();

        /// <summary>
        /// Количество вариантов.
        /// </summary>
        private int _optionCount = 0;

        /// <summary>
        /// Количество состояний среды.
        /// </summary>
        private int _environmentCount = 0;

        /// <summary>
        /// Возращает и задаёт таблицу вариантов и состояний среды.
        /// </summary>
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

        /// <summary>
        /// Возращает и задаёт матрицу таблицы.
        /// </summary>
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

        /// <summary>
        /// Возращает и задаёт количество вариантов.
        /// </summary>
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

        /// <summary>
        /// Возращает и задаёт количество состояний среды.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OptionsEnvironmentsTableControl"/> по умолчанию.
        /// </summary>
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