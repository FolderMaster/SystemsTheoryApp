using System.Collections.Generic;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Services.App
{
    public class Session
    {
        public List<Country> Countries { get; set; } = new List<Country>();

        public PairComparisonMatrix PairComparisonMatrix { get; set; } = new 
            PairComparisonMatrix(new double[6, 6]
            {
                {1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1}
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