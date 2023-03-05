using System;
using System.ComponentModel;
using System.Windows.Forms;

using GeneralizationApp.Models;

namespace GeneralizationApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для редактирования таблицы ранговой оценки экспертов.
    /// </summary>
    public partial class RankingExpertRatingTableControl : UserControl
    {
        /// <summary>
        /// Количество экспертов.
        /// </summary>
        private int _expertCount = 0;

        /// <summary>
        /// Количество альтернатив.
        /// </summary>
        private int _objectCount = 0;

        /// <summary>
        /// Возращает и задаёт таблицу ранговой оценки экспертов.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RankingExpertRatingTable RankingExpertRatingTable
        {
            get => new RankingExpertRatingTable(TableMatrix);
            set
            {
                if (value != null)
                {
                    TableMatrix = value.TableMatrix;
                }
                else
                {
                    TableMatrix = new int[0, 0];
                }
            }
        }

        /// <summary>
        /// Возращает и задаёт матрицу таблицы.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[,] TableMatrix
        {
            get => RankingExpertRatingTableGridControl.TableMatrix;
            set
            {
                RankingExpertRatingTableGridControl.TableMatrix = value;
                ExpertCount = TableMatrix.GetLength(0);
                ObjectCount = TableMatrix.GetLength(1);
            }
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
        /// Создаёт экземпляр класса <see cref="RankingExpertRatingTableControl"/> по умолчанию.
        /// </summary>
        public RankingExpertRatingTableControl()
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
            TableMatrix = new int[_expertCount, _objectCount]; 
        }
    }
}