﻿using ClassificationApp.Services.Validators;

namespace ClassificationApp.Services.Managers
{
    public static class MatrixManager
    {
        public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
            ValueValidator.AssertMatricesAreCompatible(matrix1, nameof(matrix1), matrix2, 
                nameof(matrix2));
            int count = matrix1.GetLength(0);
            int length = matrix1.GetLength(1);
            int height = matrix2.GetLength(0);
            double[,] result = new double[length, height];
            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < length; ++x)
                {
                    for (int n = 0; n < count; ++n)
                    {
                        result[y, x] += matrix1[y, n] * matrix2[n, x];
                    }
                }
            }
            return result;
        }
    }
}