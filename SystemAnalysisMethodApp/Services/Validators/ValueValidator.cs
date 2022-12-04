using Newtonsoft.Json.Linq;
using System;

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
            if(matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentException($"{name} must be square");
            }
        }

        public static void AssertMatrixLengthIsValue<T>(T[] matrix, int value, string matrixName, 
            string valueName)
        {
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
    }
}