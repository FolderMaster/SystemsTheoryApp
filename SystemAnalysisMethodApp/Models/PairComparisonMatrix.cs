using System;

using SystemAnalysisMethodApp.Services.Validators;

namespace SystemAnalysisMethodApp.Models
{
    /// <summary>
    /// Класс матрицы парных сравнений с матрицей и названиями критериев.
    /// </summary>
    public class PairComparisonMatrix
    {
        /// <summary>
        /// Массив значений случайной согласованности матрицы.
        /// </summary>
        private static readonly double[] _randomConsistencyArray = new double [10] { 0, 0, 0.58, 
            0.9, 1.12, 1.24, 1.32, 1.41, 1.45, 1.49 };

        /// <summary>
        /// Матрица.
        /// </summary>
        private double[,] _matrix = new double[0, 0];

        /// <summary>
        /// Названия критериев.
        /// </summary>
        private string[] _names = new string[0];

        /// <summary>
        /// Возращает значение случайной согласованности матрицы.
        /// </summary>
        public double RandomConsistency
        {
            get => _randomConsistencyArray[Count - 1];
        }

        /// <summary>
        /// Возращает и задаёт матрицу. Должна быть матрицей парных сравнений.
        /// </summary>
        public double[,] Matrix
        {
            get => _matrix;
            set
            {
                ValueValidator.AssertMatrixIsPairComparison(value, nameof(Matrix));
                _matrix = value;
            }
        }

        /// <summary>
        /// Возращает и задаёт названия критериев. Должна быть не пустой.
        /// </summary>
        public string[] Names
        {
            get => _names.Length != Count ? new string[Count] : _names;
            set
            {
                ValueValidator.AssertIsNotNull(value, nameof(Names));
                _names = value;
            }
        }

        /// <summary>
        /// Возращает размер матрицы.
        /// </summary>
        public int Count
        {
            get => Matrix.GetLength(0);
        }

        /// <summary>
        /// Возращает сумму собственных векторов.
        /// </summary>
        public double SumOwnVectors
        {
            get
            {
                double sum = 0;
                for(int n = 0; n < Count; ++n)
                {
                    sum += GetOwnVector(n);
                }
                return sum;
            }
        }

        /// <summary>
        /// Возращает сумму произведений суммы по столбцам и нормализованного собственного вектора.
        /// </summary>
        public double Lmax
        {
            get
            {
                double sum = 0;
                for(int n = 0; n < Count; ++n)
                {
                    sum += GetMultiplyColumnSumAndNormalizedVector(n);
                }
                return sum;
            }
        }

        /// <summary>
        /// Возращает отношение согласованности.
        /// </summary>
        public double ConsistencyRelation
        {
            get => (Lmax - Count) / (Count - 1) / RandomConsistency;
        }

        /// <summary>
        /// Возращает логическое значение, указывающее, нужен ли пересмотр.
        /// </summary>
        public bool IsRevisionNeeded
        {
            get => ConsistencyRelation >= 0.1;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PairComparisonMatrix"/> по умолчанию.
        /// </summary>
        public PairComparisonMatrix()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PairComparisonMatrix"/>.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="names">Наименования критериев.</param>
        public PairComparisonMatrix(double[,] matrix, string[] names)
        {
            Matrix = matrix;
            Names = names;
        }

        /// <summary>
        /// Рассчитывает собственный вектор строки.
        /// </summary>
        /// <param name="index">Индекс строки.</param>
        /// <returns>Длина собственного вектора.</returns>
        public double GetOwnVector(int index)
        {
            double multiplication = 1;
            for(int x = 0; x < Count; ++x)
            {
                multiplication *= Matrix[index, x];
            }
            return Math.Pow(multiplication, 1 / (double)Count);
        }

        /// <summary>
        /// Рассчитывает нормализованный собственный вектор строки.
        /// </summary>
        /// <param name="index">Индекс строки.</param>
        /// <returns>Длина нормализованного собственного вектора.</returns>
        public double GetNormalizedVector(int index)
        {
            return GetOwnVector(index) / SumOwnVectors;
        }

        /// <summary>
        /// Рассчитвает сумму по столбцу.
        /// </summary>
        /// <param name="index">Индекс столбца.</param>
        /// <returns>Сумма по столбцу.</returns>
        public double GetColumnSum(int index)
        {
            double sum = 0;
            for(int y = 0; y < Count; ++y)
            {
                sum += Matrix[y, index];
            }
            return sum;
        }

        /// <summary>
        /// Рассчитывает произведение суммы по столбцу и нормализованного собственного вектора.
        /// </summary>
        /// <param name="index">Индекс столбца.</param>
        /// <returns>Произведение суммы по столбцу и нормализованного собственного
        /// вектора.</returns>
        public double GetMultiplyColumnSumAndNormalizedVector(int index)
        {
            return GetColumnSum(index) * GetNormalizedVector(index);
        }
    }
}