using GeneralizationApp.Services.Validators;

namespace GeneralizationApp.Models
{
    public class ObjectCriteriaTable
    {
        private double[,] _tableMatrix = null;

        private double[] _weightMatrix = null;

        private bool[] _decreasingMatrix = null;

        public double[,] TableMatrix
        {
            get => _tableMatrix;
            set
            {
                ValueValidator.AssertMatrixIsPositive(value, nameof(TableMatrix));
                _tableMatrix = value;
            }
        }

        public double[] WeightMatrix
        {
            get => _weightMatrix;
            set
            {
                if (value != null)
                {
                    ValueValidator.AssertMatrixSumIsEqualToOne(value, nameof(WeightMatrix));
                }
                _weightMatrix = value;
            }
        }

        public bool[] DecreasingMatrix
        {
            get => _decreasingMatrix;
            set => _decreasingMatrix = value;
        }

        public ObjectCriteriaTable()
        {
        }

        public ObjectCriteriaTable(double[,] tableMatrix, double[] weightMatrix, bool[] 
            decreasingMatrix)
        {
            TableMatrix = tableMatrix;
            WeightMatrix = weightMatrix;
            DecreasingMatrix = decreasingMatrix;
        }
    }
}