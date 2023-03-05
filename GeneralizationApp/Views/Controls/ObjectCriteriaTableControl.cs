using System;
using System.ComponentModel;
using System.Windows.Forms;

using GeneralizationApp.Models;

namespace GeneralizationApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для редактирования таблицы оценок альтернатив.
    /// </summary>
    public partial class ObjectCriteriaTableControl : UserControl
    {
        /// <summary>
        /// Логическое значение, которое указывает, учитываются ли весы.
        /// </summary>
        private bool _withWeights = false;

        /// <summary>
        /// Количество альтернатив.
        /// </summary>
        private int _objectCount = 0;

        /// <summary>
        /// Количество критериев.
        /// </summary>
        private int _criteriaCount = 0;

        /// <summary>
        /// Возращает и задаёт таблицу оценок альтернатив.
        /// </summary>
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

        /// <summary>
        /// Возращает и задаёт матрицу таблицы.
        /// </summary>
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

        /// <summary>
        /// Возращает и задаёт логическое значение, которое указывает, учитываются ли весы.
        /// </summary>
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

        /// <summary>
        /// Возращает и задаёт массив весов.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[] WeightMatrix
        {
            get => WeightTableGridControl.DoubleArray;
            set => WeightTableGridControl.DoubleArray = value;
        }

        /// <summary>
        /// Возращает и задаёт массив логических значений, которые отвечают, убывающий параметр или
        /// нет.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool[] DecreasingMatrix
        {
            get => DecreasingCriteriaTableGridControl.BoolArray;
            set => DecreasingCriteriaTableGridControl.BoolArray = value;
        }

        /// <summary>
        /// Возращает и задаёт количество альтернатив.
        /// </summary>
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

        /// <summary>
        /// Возращает и задаёт количество критериев.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ObjectCriteriaTableControl"/> по умолчанию.
        /// </summary>
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