﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;
using SystemAnalysisMethodApp.Services.Rollupers;

namespace SystemAnalysisMethodApp.Views.Tabs
{
    /// <summary>
    /// Элемент управления для отображения финального результата.
    /// </summary>
    public partial class FinalResultTab : UserControl
    {
        /// <summary>
        /// Задаёт таблицу оценок альтернатив.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ObjectCriteriaTable ObjectCriteriaTable
        {
            set => CreateDataGridView(value);
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="FinalResultTab"/> по умолчанию.
        /// </summary>
        public FinalResultTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создаёт таблицу.
        /// </summary>
        /// <param name="table">Таблица оценок альтернатив.</param>
        private void CreateDataGridView(ObjectCriteriaTable table)
        {
            DataGridView.Rows.Clear();
            DataGridView.Columns.Clear();

            int alternativeCount = table.TableMatrix.GetLength(0);
            int criteriaCount = table.TableMatrix.GetLength(1);

            DataGridView.Columns.Add("NamesColumn", "Names");
            for (int n = 0; n < criteriaCount; ++n)
            {
                DataGridView.Columns.Add($"{table.CriteriaNames[n]}Column",
                    table.CriteriaNames[n]);
            }
            DataGridView.Columns.Add("GlobalPrioritiesColumn", "GlobalPriorities");

            for (int y = 0; y < alternativeCount; ++y)
            {
                DataGridView.Rows.Add(table.AlternativeNames[y]);
                for (int x = 0; x < criteriaCount; ++x)
                {
                    DataGridView.Rows[y].Cells[x + 1].Value = table.TableMatrix[y, x];
                }
            }

            DataGridView.Rows.Add("Criteria vectors");
            for (int x = 0; x < criteriaCount; ++x)
            {
                DataGridView.Rows[alternativeCount].Cells[x + 1].Value = table.WeightMatrix[x];
            }

            double[] globalPriorities = ObjectCriteriaTableRolluper.AdditiveRollup(table);
            int maxGlobalPriorityIndex = Array.IndexOf(globalPriorities, globalPriorities.Max());
            for (int y = 0; y < alternativeCount; ++y)
            {
                DataGridView.Rows[y].Cells[criteriaCount + 1].Value = globalPriorities[y];
            }
            DataGridView.Rows[maxGlobalPriorityIndex].DefaultCellStyle.BackColor =
                ColorManager.AnswerColor;
            ResizeDataGridView();

            Label.Text = $"Best alternative: {table.AlternativeNames[maxGlobalPriorityIndex]}";
        }

        /// <summary>
        /// Перестраивает представление таблицы.
        /// </summary>
        private void ResizeDataGridView()
        {
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                row.Height = (DataGridView.ClientRectangle.Height -
                    DataGridView.ColumnHeadersHeight) / DataGridView.Rows.Count;
            }
        }

        private void DataGridView_SizeChanged(object sender, EventArgs e)
        {
            ResizeDataGridView();
        }
    }
}