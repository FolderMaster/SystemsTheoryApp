using System.Collections.Generic;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Services.App
{
    public class Session
    {
        public List<Country> Countries { get; set; } = new List<Country>();

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

        public Session()
        {
        }

        public Session(List<Country> countries, PairComparisonMatrix pairComparisonMatrix)
        {
            Countries = countries;
            PairComparisonMatrix = pairComparisonMatrix;
        }
    }
}