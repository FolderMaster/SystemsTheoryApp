namespace ClassificationApp.Models.Countries
{
    public class Country
    {
        public CountryType Type { get; set; } = CountryType.None;

        public double Gdp { get; set; } = 0;

        public double Debt { get; set; } = 0;

        public double Density { get; set; } = 0;

        public Country()
        {
        }

        public Country(CountryType type, double gdp, double debt, double density)
        {
            Type = type;
            Gdp = gdp;
            Debt = debt;
            Density = density;
        }

        public Country(Country country)
        {
            Type = country.Type;
            Gdp = country.Gdp;
            Debt = country.Debt;
            Density = country.Density;
        }
    }
}