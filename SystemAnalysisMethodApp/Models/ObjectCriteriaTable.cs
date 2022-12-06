using System.Xml.Linq;
using SystemAnalysisMethodApp.Services.Validators;

namespace SystemAnalysisMethodApp.Models
{
    public class ObjectCriteriaTable
    {
        private double[,] _tableMatrix = null;

        private double[] _weightMatrix = null;

        private bool[] _decreasingMatrix = null;

        private string[] _alternativeNames = null;

        private string[] _criteriaNames = null;

        public string[] AlternativeNames
        {
            get => _alternativeNames;
            set
            {
                ValueValidator.AssertIsNotNull(value, nameof(AlternativeNames));
                _alternativeNames = value;
            }
        }

        public string[] CriteriaNames
        {
            get => _criteriaNames;
            set
            {
                ValueValidator.AssertIsNotNull(value, nameof(CriteriaNames));
                _criteriaNames = value;
            }
        }

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