using GeneralizationApp.Models;

namespace GeneralizationApp.Services.App
{
    public class Session
    {
        public RankingExpertRatingTable RankingExpertRatingTable { get; set; } = null;

        public ScoringExpertRatingTable ScoringExpertRatingTable { get; set; } = null;

        public ObjectCriteriaTable ObjectCriteriaRollupTable { get; set; } = null;

        public Session()
        {
        }

        public Session(RankingExpertRatingTable rankingExpertRatingTable, ScoringExpertRatingTable 
            scoringExpertRatingTable, ObjectCriteriaTable objectCriteriaRollupTable)
        {
            RankingExpertRatingTable = rankingExpertRatingTable;
            ScoringExpertRatingTable = scoringExpertRatingTable;
            ObjectCriteriaRollupTable = objectCriteriaRollupTable;
        }
    }
}