using ClassificationApp.Services.Validators;

namespace ClassificationApp.Services.Managers
{
    /// <summary>
    /// Класс менеджера работы с матрицами, предоставляющий методы работы с ними.
    /// </summary>
    public static class MatrixManager
    {
        /// <summary>
        /// Умножает матрицы.
        /// </summary>
        /// <param name="matrix1">Первая матрица.</param>
        /// <param name="matrix2">Вторая матрица.</param>
        /// <returns>Матрица - результат умножения матриц.</returns>
        public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
            ValueValidator.AssertMatricesAreCompatible(matrix1, nameof(matrix1), matrix2, 
                nameof(matrix2));
            int count = matrix1.GetLength(1);
            int length = matrix2.GetLength(1);
            int height = matrix1.GetLength(0);
            double[,] result = new double[height, length];
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