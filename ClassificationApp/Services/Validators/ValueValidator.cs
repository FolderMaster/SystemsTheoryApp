using System;

namespace ClassificationApp.Services.Validators
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

        public static void AssertMatricesAreCompatible(double[,] matrix1, string name1, double[,]
        matrix2, string name2)
        {
            AssertIsNotNull(matrix1, name1);
            AssertIsNotNull(matrix2, name2);
            if (matrix1.GetLength(0) != matrix2.GetLength(1))
            {
                throw new ArgumentException($"{name1} and {name2} must be compatible");
            }
        }
    }
}