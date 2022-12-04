using System;

using SystemAnalysisMethodApp.Services.Validators;

namespace SystemAnalysisMethodApp.Models
{
    public class PairComparisonMatrix
    {
        private double[,] _matrix = new double[0, 0];

        public double[,] Matrix
        {
            get => _matrix;
            set
            {
                ValueValidator.AssertMatrixIsPairComparison(value, nameof(Matrix));
                _matrix = value;
            }
        }

        public int Count
        {
            get => Matrix.GetLength(0);
        }

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

        public double ConsistencyRelation
        {
            get
            {
                double sum = 0;
                for(int n = 0; n < Count; ++n)
                {
                    sum = GetSumOfColumn(n) * GetNormalizedVector(n);
                }

                const double consistencyIndex = 1.24;
                return (sum - Count) / (Count - 1) / consistencyIndex;
            }
        }

        public bool IsRevisionNeeded
        {
            get => ConsistencyRelation >= 0.1;
        }

        public PairComparisonMatrix()
        {
        }

        public PairComparisonMatrix(double[,] matrix)
        {
            Matrix = matrix;
        }

        public double GetOwnVector(int index)
        {
            double multiplication = 1;
            for(int x = 0; x < Count; ++x)
            {
                multiplication *= Matrix[index, x];
            }
            return Math.Pow(multiplication, 1 / (double)Count);
        }

        public double GetNormalizedVector(int index)
        {
            return GetOwnVector(index) / SumOwnVectors;
        }

        public double GetSumOfColumn(int index)
        {
            double sum = 0;
            for(int y = 0; y < Count; ++y)
            {
                sum += Matrix[y, index];
            }
            return sum;
        }
    }
}