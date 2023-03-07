using System;
using System.Linq;

namespace SystemAnalysisMethodApp.Services.Validators
{
    /// <summary>
    /// Класс валидации данных, предоставляющий методы.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет, не нулевое ли значение.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="value">Значение.</param>
        /// <param name="name">Наменование значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertIsNotNull<T>(T value, string name)
        {
            if (value == null)
            {
                throw new ArgumentException($"{name} must be not null");
            }
        }

        /// <summary>
        /// Проверяет, не лежит ли значение за пределами диапазона.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Минимум.</param>
        /// <param name="max">Максимум.</param>
        /// <param name="name">Наменование значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(double value, double min, double max, string name)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"{name} must be in range [{min};{max}]");
            }
        }

        /// <summary>
        /// Проверяет, не отрицательное ли значение.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="name">Наменование значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueIsPositive(double value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} must be positive");
            }
        }

        /// <summary>
        /// Проверяет, матрица квадратная ли.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="matrix">Матрица.</param>
        /// <param name="name">Наименование матрицы.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertMatrixIsSquare<T>(T[,] matrix, string name)
        {
            AssertIsNotNull(matrix, name);
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentException($"{name} must be square");
            }
        }

        /// <summary>
        /// Проверяет, не отрицательное ли значение у элемента матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="name">Наименование матрицы.</param>
        public static void AssertMatrixIsPositive(double[,] matrix, string name)
        {
            AssertIsNotNull(matrix, name);
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);
            for (int y = 0; y < rowCount; ++y)
            {
                for (int x = 0; x < columnCount; ++x)
                {
                    AssertValueIsPositive(matrix[y, x], $"{name}[{y}, {x}]");
                }
            }
        }

        /// <summary>
        /// Проверяет, длина матрицы равна ли значению.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="matrix">Матрица.</param>
        /// <param name="value">Значение.</param>
        /// <param name="matrixName">Наименование матрицы.</param>
        /// <param name="valueName">Наименование значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertMatrixLengthIsValue<T>(T[] matrix, int value, string matrixName, 
            string valueName)
        {
            AssertIsNotNull(matrix, matrixName);
            AssertIsNotNull(value, valueName);
            if (matrix.Length != value)
            {
                throw new ArgumentException($"{matrixName}'s length must be {valueName}");
            }
        }

        /// <summary>
        /// Проверяет, является ли элемент к элементам матрицы парного сравнения.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="name">Наименвание значения.</param>
        public static void AssertIsElementOfPairComparisonMatrix(double value, string name)
        {
            AssertValueInRange(value, 0, 9, name);
        }

        /// <summary>
        /// Проверяет, является ли матрица матрицей парных сравнений.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="name">Наименование матрицы.</param>
        public static void AssertMatrixIsPairComparison(double[,] matrix, string name)
        {
            AssertMatrixIsSquare(matrix, name);
            int count = matrix.GetLength(0);
            for(int y = 0; y < count; ++y)
            {
                for (int x = 0; x < count; ++x)
                {
                    AssertIsElementOfPairComparisonMatrix(matrix[y, x], $"{name}[{y}, {x}]");
                }
            }
        }

        /// <summary>
        /// Проверяет, сумма элементов матрицы равна ли 1.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="name">Наименивание матрицы.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertMatrixSumIsEqualToOne(double[] matrix, string name)
        {
            AssertIsNotNull(matrix, name);
            if (Math.Abs(matrix.Sum() - 1) > 0.1)
            {
                throw new ArgumentException($"{name}'s sum must be equal to one");
            }
        }
    }
}