using GeneralizationApp.Services.Validators;

namespace GeneralizationApp.Models
{
    public class RankingExpertRatingTable
    {
        private int[,] _tableMatrix = null;

        public int[,] TableMatrix
        {
            get => _tableMatrix;
            set
            {
                ValueValidator.AssertMatrixIsRankingTable(value, nameof(TableMatrix));
                _tableMatrix = value;
            }
        }

        public RankingExpertRatingTable()
        {
        }

        public RankingExpertRatingTable(int[,] tableMatrix)
        {
            TableMatrix = tableMatrix;
        }
    }
}