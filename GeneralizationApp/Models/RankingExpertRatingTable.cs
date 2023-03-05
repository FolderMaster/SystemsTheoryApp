using GeneralizationApp.Services.Validators;

namespace GeneralizationApp.Models
{
    /// <summary>
    /// Класс таблицы ранговой оценки экспертов с матрицей таблицы.
    /// </summary>
    public class RankingExpertRatingTable
    {
        /// <summary>
        /// Матрица таблицы.
        /// </summary>
        private int[,] _tableMatrix = null;

        /// <summary>
        /// Возращает и задаёт матрицу таблицы. Должна быть ранговой.
        /// </summary>
        public int[,] TableMatrix
        {
            get => _tableMatrix;
            set
            {
                ValueValidator.AssertMatrixIsRankingTable(value, nameof(TableMatrix));
                _tableMatrix = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RankingExpertRatingTable"/> по умолчанию.
        /// </summary>
        public RankingExpertRatingTable()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RankingExpertRatingTable"/>.
        /// </summary>
        /// <param name="tableMatrix">Матрица таблицы.</param>
        public RankingExpertRatingTable(int[,] tableMatrix)
        {
            TableMatrix = tableMatrix;
        }
    }
}