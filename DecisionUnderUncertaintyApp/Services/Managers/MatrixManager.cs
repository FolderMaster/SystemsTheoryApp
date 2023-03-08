using System;

namespace DecisionUnderUncertaintyApp.Services.Managers
{
    /// <summary>
    /// Класс менеджера работы с матрицами, предоставляющий методы работы с ними.
    /// </summary>
    public static class MatrixManager
    {
        /// <summary>
        /// Находит индекс элемента матрицы по условию.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="matrix">Матрица.</param>
        /// <param name="condition">Условие выбора.</param>
        /// <returns>Индекс элемента матрицы по условию.</returns>
        public static int GetValueIndexByCondition<T>(T[] matrix, Func<T, T, bool> condition)
        {
            int columnCount = matrix.GetLength(0);
            int index = 0;
            T result = matrix[index];
            for (int x = 1; x < columnCount; ++x)
            {
                if (condition(result, matrix[x]))
                {
                    result = matrix[x];
                    index = x;
                }
            }
            return index;
        }

        /// <summary>
        /// Находит индекс минимального элемента матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <returns>Индекс минимального элемента матрицы.</returns>
        public static int GetMinIndex(double[] matrix)
        {
            return GetValueIndexByCondition(matrix, (a, b) => a > b);
        }

        /// <summary>
        /// Находит индекс максимального элемента матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <returns>Индекс максимального элемента матрицы.</returns>
        public static int GetMaxIndex(double[] matrix)
        {
            return GetValueIndexByCondition(matrix, (a, b) => a < b);
        }

        /// <summary>
        /// Находит элемент строки матрицы по условию.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="matrix">Матрица.</param>
        /// <param name="rowIndex">Индекс строки.</param>
        /// <param name="condition">Условие выбора.</param>
        /// <returns>Элемента строки матрицы по условию.</returns>
        public static T GetRowValueByCondition<T>(T[,] matrix, int rowIndex, Func<T, T, bool>
            condition)
        {
            int columnCount = matrix.GetLength(1);
            T result = matrix[rowIndex, 0];
            for (int x = 1; x < columnCount; ++x)
            {
                if (condition(result, matrix[rowIndex, x]))
                {
                    result = matrix[rowIndex, x];
                }
            }
            return result;
        }

        /// <summary>
        /// Находит минимальный элемент строки матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="rowIndex">Индекс строки.</param>
        /// <returns>Минимальный элемент строки матрицы.</returns>
        public static double GetRowMin(double[,] matrix, int rowIndex)
        {
            return GetRowValueByCondition(matrix, rowIndex, (a, b) => a > b);
        }

        /// <summary>
        /// Находит максимальный элемент строки матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="rowIndex">Индекс строки.</param>
        /// <returns>Максимальный элемент строки матрицы.</returns>
        public static double GetRowMax(double[,] matrix, int rowIndex)
        {
            return GetRowValueByCondition(matrix, rowIndex, (a, b) => a < b);
        }

        /// <summary>
        /// Находит элемент столбца матрицы по условию.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="matrix">Матрица.</param>
        /// <param name="columnIndex">Индекс столбца.</param>
        /// <param name="condition">Условие выбора.</param>
        /// <returns>Элемента столбца матрицы по условию.</returns>
        public static T GetColumnValueByCondition<T>(T[,] matrix, int columnIndex, Func<T, T, bool>
            condition)
        {
            int columnCount = matrix.GetLength(1);
            T result = matrix[0, columnIndex];
            for (int y = 1; y < columnCount; ++y)
            {
                if (condition(result, matrix[y, columnIndex]))
                {
                    result = matrix[y, columnIndex];
                }
            }
            return result;
        }

        /// <summary>
        /// Находит максимальный элемент столбца матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="columnIndex">Индекс столбца.</param>
        /// <returns>Максимальный элемент столбца матрицы.</returns>
        public static double GetColumnMax(double[,] matrix, int columnIndex)
        {
            return GetColumnValueByCondition(matrix, columnIndex, (a, b) => a < b);
        }

        /// <summary>
        /// Умножает матрицу на число.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="number">Число.</param>
        /// <returns>Умноженная на число, матрица.</returns>
        public static double[,] MultiplyMatrixByNumber(double[,] matrix, double number)
        {
            int columnCount = matrix.GetLength(1);
            int rowCount = matrix.GetLength(0);
            double[,] result = new double[rowCount, columnCount];
            for (int y = 0; y < rowCount; ++y)
            {
                for (int x = 0; x < columnCount; ++x)
                {
                    result[y, x] = number * matrix[y, x];
                }
            }
            return result;
        }
    }
}