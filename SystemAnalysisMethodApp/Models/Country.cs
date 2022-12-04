namespace SystemAnalysisMethodApp.Models
{
    public class Country
    {
        public string Name { get; set; } = "";

        public double AverageLivingCost { get; set; } = 0;

        public double TripPrice { get; set; } = 0;

        public СharacterType AttractionCount { get; set; } = СharacterType.Average;

        public СharacterType Climate { get; set; } = СharacterType.Average;

        public СharacterType DevelopmentLevel { get; set; } = СharacterType.Average;

        public СharacterType TouristPopularity { get; set; } = СharacterType.Average;

        public Country()
        {
        }

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