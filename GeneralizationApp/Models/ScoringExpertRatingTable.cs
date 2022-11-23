namespace GeneralizationApp.Models
{
    public class ScoringExpertRatingTable
    {
        private double[,] _tableMatrix = new double[0, 0];

        private double[] _weightMatrix = new double[0];

        public double[,] TableMatrix
        {
            get => _tableMatrix;
            set => _tableMatrix = value;
        }

        public double[] WeightMatrix
        {
            get => _weightMatrix;
            set => _weightMatrix = value;
        }

        public ScoringExpertRatingTable()
        {
        }

        public ScoringExpertRatingTable(double[,] tableMatrix, double[] weightMatrix)
        {
            TableMatrix = tableMatrix;
            WeightMatrix = weightMatrix;
        }
    }
}