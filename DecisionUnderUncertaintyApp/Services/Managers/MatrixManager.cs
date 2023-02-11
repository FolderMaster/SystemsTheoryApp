using System;

namespace DecisionUnderUncertaintyApp.Services.Managers
{
    public static class MatrixManager
    {
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

        public static int GetMinIndex(double[] matrix)
        {
            return GetValueIndexByCondition(matrix, (a, b) => a > b);
        }

        public static int GetMaxIndex(double[] matrix)
        {
            return GetValueIndexByCondition(matrix, (a, b) => a < b);
        }

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

        public static double GetRowMin(double[,] matrix, int rowIndex)
        {
            return GetRowValueByCondition(matrix, rowIndex, (a, b) => a > b);
        }

        public static double GetRowMax(double[,] matrix, int rowIndex)
        {
            return GetRowValueByCondition(matrix, rowIndex, (a, b) => a < b);
        }

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

        public static double GetColumnMax(double[,] matrix, int columnIndex)
        {
            return GetColumnValueByCondition(matrix, columnIndex, (a, b) => a < b);
        }

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