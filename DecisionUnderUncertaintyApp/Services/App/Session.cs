using DecisionUnderUncertaintyApp.Models;

namespace DecisionUnderUncertaintyApp.Services.App
{
    /// <summary>
    /// Класс сессии с таблицей вариантов и состояний среды.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Возращает и задаёт таблицу вариантов и состояний среды.
        /// </summary>
        public OptionsEnvironmentsTable OptionsEnvironmentsTable { get; set; } = new
            OptionsEnvironmentsTable();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Session"/> по умолчанию.
        /// </summary>
        public Session()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Session"/>.
        /// </summary>
        /// <param name="optionsEnvironmentsTable">Таблица вариантов и состояний среды.</param>
        public Session(OptionsEnvironmentsTable optionsEnvironmentsTable)
        {
            OptionsEnvironmentsTable = optionsEnvironmentsTable;
        }
    }
}