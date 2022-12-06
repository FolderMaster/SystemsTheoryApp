using System;
using System.Linq;

namespace SystemAnalysisMethodApp.Services.Validators
{
    public static class ValueValidator
    {
        public static void AssertIsNotNull<T>(T value, string name)
        {
            if (value == null)
            {
                throw new ArgumentException($"{name} must be not null");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string name)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"{name} must be in range [{min};{max}]");
            }
        }

        public static void AssertValueIsPositive(double value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} must be positive");
            }
        }

        public static void AssertMatrixIsSquare<T>(T[,] matrix, string name)
        {
            AssertIsNotNull(matrix, name);
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentException($"{name} must be square");
            }
        }

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

        public static void AssertIsElementOfPairComparisonMatrix(double value, string name)
        {
            AssertValueInRange(value, 0, 9, name);
        }

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