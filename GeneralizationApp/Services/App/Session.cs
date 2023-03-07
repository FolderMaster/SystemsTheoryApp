using GeneralizationApp.Models;

namespace GeneralizationApp.Services.App
{
    /// <summary>
    /// Класс сессии с таблицей ранговой оценки экспертов, таблицей балльной оценки экспертов,
    /// таблицей оценок альтернатив.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Возращает и задаёт таблицу ранговой оценки экспертов.
        /// </summary>
        public RankingExpertRatingTable RankingExpertRatingTable { get; set; } = null;

        /// <summary>
        /// Возращает и задаёт таблицу балльной оценки экспертов.
        /// </summary>
        public ScoringExpertRatingTable ScoringExpertRatingTable { get; set; } = null;

        /// <summary>
        /// Возращает и задаёт таблицу оценок альтернатив.
        /// </summary>
        public ObjectCriteriaTable ObjectCriteriaRollupTable { get; set; } = null;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Session"/> по умолчанию.
        /// </summary>
        public Session()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Session"/>.
        /// </summary>
        /// <param name="rankingExpertRatingTable">Таблица ранговой оценки экспертов.</param>
        /// <param name="scoringExpertRatingTable">Таблица балльной оценки экспертов.</param>
        /// <param name="objectCriteriaRollupTable">Таблица оценок альтернатив.</param>
        public Session(RankingExpertRatingTable rankingExpertRatingTable, ScoringExpertRatingTable 
            scoringExpertRatingTable, ObjectCriteriaTable objectCriteriaRollupTable)
        {
            RankingExpertRatingTable = rankingExpertRatingTable;
            ScoringExpertRatingTable = scoringExpertRatingTable;
            ObjectCriteriaRollupTable = objectCriteriaRollupTable;
        }
    }
}