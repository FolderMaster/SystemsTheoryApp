using System;
using System.Linq;

namespace GeneralizationApp.Services.Validators
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

        public static void AssertValueIsPositive(int value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} must be positive");
            }
        }

        public static void AssertValueIsPositive(double value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} must be positive");
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

        public static void AssertMatrixIsRankingTable(int[,] matrix, string name)
        {
            AssertIsNotNull(matrix, name);
            int expertCount = matrix.GetLength(0);
            int objectCount = matrix.GetLength(1);
            for (int y = 0; y < expertCount; ++y)
            {
                for (int x = 0; x < objectCount; ++x)
                {
                    bool flag = false;
                    for (int n = 0; n < objectCount; ++n)
                    {
                        if (matrix[y, n] == x + 1)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        throw new ArgumentException($"{name}'s row {y} must contain ranks");
                    }
                }
            }
        }

        public static void AssertMatrixSumIsEqualToOne(double[] matrix, string name)
        {
            AssertIsNotNull(matrix, name);
            if(Math.Abs(matrix.Sum() - 1) > 0.1)
            {
                throw new ArgumentException($"{name}'s sum must be equal to one");
            }
        }
    }
}