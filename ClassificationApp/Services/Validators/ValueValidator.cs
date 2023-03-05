using System;

namespace ClassificationApp.Services.Validators
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
        /// Проверяет, являются ли матрицы смежными к друг другу.
        /// </summary>
        /// <param name="matrix1">Первая матрица.</param>
        /// <param name="name1">Наименование первой матрицы.</param>
        /// <param name="matrix2">Вторая матрица.</param>
        /// <param name="name2">Наименование второй матрицы.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertMatricesAreCompatible(double[,] matrix1, string name1, double[,]
        matrix2, string name2)
        {
            AssertIsNotNull(matrix1, name1);
            AssertIsNotNull(matrix2, name2);
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                throw new ArgumentException($"{name1} and {name2} must be compatible");
            }
        }
    }
}