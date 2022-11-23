using System;

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

        public static void AssertMatrixIsRankingExpertRatingTable(int[,] matrix, string name)
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
    }
}