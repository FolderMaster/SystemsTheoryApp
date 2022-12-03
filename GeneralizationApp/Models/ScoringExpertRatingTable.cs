using GeneralizationApp.Services.Validators;

namespace GeneralizationApp.Models
{
    public class ScoringExpertRatingTable
    {
        private double[,] _tableMatrix = null;

        private double[] _сompetenceMatrix = null;

        public double[,] TableMatrix
        {
            get => _tableMatrix;
            set
            {
                ValueValidator.AssertMatrixIsPositive(value, nameof(TableMatrix));
                _tableMatrix = value;
            }
        }

        public double[] CompetenceMatrix
        {
            get => _сompetenceMatrix;
            set
            {
                if(value != null)
                {
                    ValueValidator.AssertMatrixSumIsEqualToOne(value, nameof(CompetenceMatrix));
                }
                _сompetenceMatrix = value;
            }
        }

        public ScoringExpertRatingTable()
        {
        }

        public ScoringExpertRatingTable(double[,] tableMatrix, double[] сompetenceMatrix)
        {
            TableMatrix = tableMatrix;
            CompetenceMatrix = сompetenceMatrix;
        }
    }
}