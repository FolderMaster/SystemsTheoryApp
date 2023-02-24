namespace ClassificationApp.Models.Countries
{
    /// <summary>
    /// Класс страны, хранящий тип страны, ВВП, долг, плотность населения.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Возращает и задаёт тип страны.
        /// </summary>
        public CountryType Type { get; set; } = CountryType.None;

        /// <summary>
        /// Возращает и задаёт ВВП.
        /// </summary>
        public double Gdp { get; set; } = 0;

        /// <summary>
        /// Возращает и задаёт долг.
        /// </summary>
        public double Debt { get; set; } = 0;

        /// <summary>
        /// Возращает и задаёт плотность населения.
        /// </summary>
        public double Density { get; set; } = 0;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Country"/> по умолчанию.
        /// </summary>
        public Country()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Country"/>.
        /// </summary>
        /// <param name="type">Тип страны.</param>
        /// <param name="gdp">ВВП.</param>
        /// <param name="debt">Долг.</param>
        /// <param name="density">Плотность населения.</param>
        public Country(CountryType type, double gdp, double debt, double density)
        {
            Type = type;
            Gdp = gdp;
            Debt = debt;
            Density = density;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Country"/> копированием.
        /// </summary>
        /// <param name="country">Страна.</param>
        public Country(Country country)
        {
            Type = country.Type;
            Gdp = country.Gdp;
            Debt = country.Debt;
            Density = country.Density;
        }
    }
}