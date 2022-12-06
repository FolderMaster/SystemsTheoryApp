using System;

using SystemAnalysisMethodApp.Services.Validators;

namespace SystemAnalysisMethodApp.Models
{
    public class PairComparisonMatrix
    {
        private static readonly double[] _randomConsistencyArray = new double [10] { 0, 0, 0.58, 
            0.9, 1.12, 1.24, 1.32, 1.41, 1.45, 1.49 };

        private double[,] _matrix = new double[0, 0];

        private string[] _names = new string[0];

        public double RandomConsistency
        {
            get => _randomConsistencyArray[Count - 1];
        }

        public double[,] Matrix
        {
            get => _matrix;
            set
            {
                ValueValidator.AssertMatrixIsPairComparison(value, nameof(Matrix));
                _matrix = value;
            }
        }

        public string[] Names
        {
            get => _names.Length != Count ? new string[Count] : _names;
            set
            {
                ValueValidator.AssertIsNotNull(value, nameof(Names));
                _names = value;
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

        public double ConsistencyRelation
        {
            get => (Lmax - Count) / (Count - 1) / RandomConsistency;
        }

        public bool IsRevisionNeeded
        {
            get => ConsistencyRelation >= 0.1;
        }

        public PairComparisonMatrix()
        {
        }

        public PairComparisonMatrix(double[,] matrix, string[] names)
        {
            Matrix = matrix;
            Names = names;
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

        public double GetColumnSum(int index)
        {
            double sum = 0;
            for(int y = 0; y < Count; ++y)
            {
                sum += Matrix[y, index];
            }
            return sum;
        }

        public double GetMultiplyColumnSumAndNormalizedVector(int index)
        {
            return GetColumnSum(index) * GetNormalizedVector(index);
        }
    }
}