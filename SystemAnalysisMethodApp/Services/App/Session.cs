using System.Collections.Generic;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Services.App
{
    /// <summary>
    /// Класс сессии c странами и матрица парного сравнения критериев.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Возращает и задаёт страны.
        /// </summary>
        public List<Country> Countries { get; set; } = new List<Country>();

        /// <summary>
        /// Возращает и задаёт матрицу парного сравнения критериев.
        /// </summary>
        public PairComparisonMatrix PairComparisonMatrix { get; set; } = new PairComparisonMatrix(
            new double[6, 6]
            {
                {1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1}
            },
            new string[6]
            {
                nameof(Country.AverageLivingCost),
                nameof(Country.TripPrice),
                nameof(Country.AttractionCount),
                nameof(Country.Climate),
                nameof(Country.DevelopmentLevel),
                nameof(Country.TouristPopularity)
            });

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Session"/> по умолчанию.
        /// </summary>
        public Session()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Session"/>.
        /// </summary>
        /// <param name="countries">Страны.</param>
        /// <param name="pairComparisonMatrix">Матрица парного сравнения критериев.</param>
        public Session(List<Country> countries, PairComparisonMatrix pairComparisonMatrix)
        {
            Countries = countries;
            PairComparisonMatrix = pairComparisonMatrix;
        }
    }
}