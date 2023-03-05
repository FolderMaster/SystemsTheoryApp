using GeneralizationApp.Services.Validators;

namespace GeneralizationApp.Models
{
    /// <summary>
    /// Класс таблицы балльной оценки экспертов с матрицей таблицы и массивом компетенций.
    /// </summary>
    public class ScoringExpertRatingTable
    {
        /// <summary>
        /// Матрица таблицы.
        /// </summary>
        private double[,] _tableMatrix = null;

        /// <summary>
        /// Массив компетенций.
        /// </summary>
        private double[] _сompetenceMatrix = null;

        /// <summary>
        /// Возращает и задаёт матрицу таблицы. Элементы должны быть положительными.
        /// </summary>
        public double[,] TableMatrix
        {
            get => _tableMatrix;
            set
            {
                ValueValidator.AssertMatrixIsPositive(value, nameof(TableMatrix));
                _tableMatrix = value;
            }
        }

        /// <summary>
        /// Возращает и задаёт массив компетенций. Сумма элементов должна быть равна 1.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ScoringExpertRatingTable"/> по умолчанию.
        /// </summary>
        public ScoringExpertRatingTable()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ScoringExpertRatingTable"/>.
        /// </summary>
        /// <param name="tableMatrix">Матрица таблицы.</param>
        /// <param name="сompetenceMatrix">Массив компетенций.</param>
        public ScoringExpertRatingTable(double[,] tableMatrix, double[] сompetenceMatrix)
        {
            TableMatrix = tableMatrix;
            CompetenceMatrix = сompetenceMatrix;
        }
    }
}