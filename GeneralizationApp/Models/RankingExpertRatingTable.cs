namespace GeneralizationApp.Models
{
    public class RankingExpertRatingTable
    {
        private int[,] _tableMatrix = new int[0, 0];

        public int[,] TableMatrix
        {
            get => _tableMatrix;
            set => _tableMatrix = value;
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