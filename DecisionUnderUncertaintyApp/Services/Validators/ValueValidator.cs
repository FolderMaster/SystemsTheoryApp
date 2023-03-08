using System;

namespace DecisionUnderUncertaintyApp.Services.Validators
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
        public static void AssertMatrixIsNotNull<T>(T[,] matrix, string name)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException($"{name} is null!");
            }
            if (matrix.Length == 0)
            {
                throw new ArgumentNullException($"{name}'s legth is equal 0!");
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
    }
}