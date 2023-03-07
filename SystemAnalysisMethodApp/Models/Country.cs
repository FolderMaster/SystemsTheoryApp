namespace SystemAnalysisMethodApp.Models
{
    /// <summary>
    /// Класс страны с наименованием, средней стоимостью проживания, стоимостью поездки,
    /// количеством достопримечательностей, климатом, развитием страны, популярностью среди
    /// туристов.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Средняя стоимость проживания.
        /// </summary>
        public double AverageLivingCost { get; set; } = 0;

        /// <summary>
        /// Стоимость поездки.
        /// </summary>
        public double TripPrice { get; set; } = 0;

        /// <summary>
        /// Количество достопримечательностей.
        /// </summary>
        public СharacterType AttractionCount { get; set; } = СharacterType.Average;

        /// <summary>
        /// Климат.
        /// </summary>
        public СharacterType Climate { get; set; } = СharacterType.Average;

        /// <summary>
        /// Развитие страны.
        /// </summary>
        public СharacterType DevelopmentLevel { get; set; } = СharacterType.Average;

        /// <summary>
        /// Популярность среди туристов.
        /// </summary>
        public СharacterType TouristPopularity { get; set; } = СharacterType.Average;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Country"/> по умолчанию.
        /// </summary>
        public Country()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Country"/>.
        /// </summary>
        /// <param name="name">Наименование.</param>
        /// <param name="averageLivingCost">Средняя стоимость проживания.</param>
        /// <param name="tripPrice">Стоимость поездки.</param>
        /// <param name="attractionCount">Количество достопримечательностей.</param>
        /// <param name="climate">Климат.</param>
        /// <param name="developmentLevel">Развитие страны.</param>
        /// <param name="touristPopularity">Популярность среди туристов.</param>
        public Country(string name, double averageLivingCost, double tripPrice, СharacterType 
            attractionCount, СharacterType climate, СharacterType developmentLevel, СharacterType 
            touristPopularity)
        {
            Name = name;
            AverageLivingCost = averageLivingCost;
            TripPrice = tripPrice;
            AttractionCount = attractionCount;
            Climate = climate;
            DevelopmentLevel = developmentLevel;
            TouristPopularity = touristPopularity;
        }
    }
}