﻿using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using GeneralizationApp.Services.Validators;

namespace GeneralizationApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для редактирования матрицы таблицы балльных оценок.
    /// </summary>
    public partial class ScoringTableGridControl : UserControl
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
        /// Матрица таблицы.
        /// </summary>
        private double[,] _tableMatrix = new double[0, 0];

        /// <summary>
        /// Таблица.
        /// </summary>
        private DataTable _dataTable = CreateDataTable(0, 0);

        /// <summary>
        /// Возращает и задаёт матрицу таблицы.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[,] TableMatrix
        {
            get => _tableMatrix;
            set
            {
                _tableMatrix = value;
                _expertCount = value.GetLength(0);
                _objectCount = value.GetLength(1);
                _dataTable = CreateDataTable(_expertCount, _objectCount);
                UpdateDataTable();
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ScoringTableGridControl"/> по умолчанию.
        /// </summary>
        public ScoringTableGridControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

        /// <summary>
        /// Создаёт таблицу.
        /// </summary>
        /// <param name="expertCount">Количество экспертов.</param>
        /// <param name="objectCount">Количество альтернатив.</param>
        /// <returns>Таблица.</returns>
        private static DataTable CreateDataTable(int expertCount, int objectCount)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("*", typeof(string));
            for (int n = 0; n < objectCount; ++n)
            {
                dataTable.Columns.Add($"{n + 1}", typeof(double));
            }
            if (dataTable.Columns.Count > 0)
            {
                dataTable.Columns[0].ReadOnly = true;
            }

            for (int n = 0; n < expertCount; ++n)
            {
                dataTable.Rows.Add($"{n + 1}");
            }

            return dataTable;
        }

        /// <summary>
        /// Обновляет таблицу.
        /// </summary>
        private void UpdateDataTable()
        {
            for (int y = 0; y < _expertCount; ++y)
            {
                for (int x = 0; x < _objectCount; x++)
                {
                    _dataTable.Rows[y][x + 1] = TableMatrix[y, x];
                }
            }
            DataGridView.DataSource = _dataTable;
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            try
            {
                double value = double.Parse((string)e.FormattedValue);
                ValueValidator.AssertValueIsPositive(value, $"TableMatrix[{rowIndex}, " +
                    $"{columnIndex - 1}]");
                DataGridView[columnIndex, rowIndex].ErrorText = "";
                DataGridView[columnIndex, rowIndex].Style.BackColor = ColorManager.CorrectColor;
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                DataGridView[columnIndex, rowIndex].ErrorText = ex.Message;
                DataGridView[columnIndex, rowIndex].Style.BackColor = ColorManager.ErrorColor;
            }
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            object value = DataGridView[columnIndex, rowIndex].Value;
            string stringValue = value == null ? "" : value.ToString();
            TableMatrix[rowIndex, columnIndex - 1] = double.Parse(stringValue);
        }
    }
}