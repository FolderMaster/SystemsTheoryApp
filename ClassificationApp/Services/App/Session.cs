using System.Collections.Generic;

using ClassificationApp.Models.Countries;

namespace ClassificationApp.Services.App
{
    /// <summary>
    /// Класс сессии с списками стран для обучения и теста.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Возращает и задаёт список стран для обучения.
        /// </summary>
        public List<Country> Education { get; set; } = new List<Country>();

        /// <summary>
        /// Возращает и задаёт список стран для теста.
        /// </summary>
        public List<Country> Test { get; set; } = new List<Country>();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Session"/> по умолчанию.
        /// </summary>
        public Session()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Session"/>.
        /// </summary>
        /// <param name="education">Список стран для обучения.</param>
        /// <param name="test">Список стран для теста.</param>
        public Session(List<Country> education, List<Country> test)
        {
            Education = education;
            Test = test;
        }
    }
}