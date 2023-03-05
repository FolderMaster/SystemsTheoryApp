using System;
using System.ComponentModel;
using System.Windows.Forms;

using GeneralizationApp.Models;

namespace GeneralizationApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для редактирования таблицы балльной оценки экспертов.
    /// </summary>
    public partial class ScoringExpertRatingTableControl : UserControl
    {
        /// <summary>
        /// Логическое значение, которое указывает, учитываются ли компетенции.
        /// </summary>
        private bool _withCompetencies = false;

        /// <summary>
        /// Количество экспертов.
        /// </summary>
        private int _expertCount = 0;

        /// <summary>
        /// Количество альтернатив.
        /// </summary>
        private int _objectCount = 0;

        /// <summary>
        /// Возращает и задаёт таблицу балльной оценки экспертов.
        /// </summary>
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
                ExpertCount = TableMatrix.GetLength(0);
                ObjectCount = TableMatrix.GetLength(1);
            }
        }

        /// <summary>
        /// Возращает и задаёт логическое значение, которое указывает, учитываются ли компетенции.
        /// </summary>
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

        /// <summary>
        /// Возращает и задаёт массив компетенций.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[] CompetenceMatrix
        {
            get => CompetenceTableGridControl.DoubleArray;
            set => CompetenceTableGridControl.DoubleArray = value;
        }

        /// <summary>
        /// Возращает и задаёт количество экспертов.
        /// </summary>
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
        /// Создаёт экземпляр класса <see cref="ScoringExpertRatingTableControl"/> по умолчанию.
        /// </summary>
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