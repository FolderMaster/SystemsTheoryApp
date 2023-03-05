namespace GeneralizationApp.Services.App
{
    /// <summary>
    /// Класс формата сохранения с сессией.
    /// </summary>
    public class SaveFormat
    {
        /// <summary>
        /// Возращает и задаёт сессию.
        /// </summary>
        public Session Session { get; set; } = new Session();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="SaveFormat"/> по умолчанию.
        /// </summary>
        public SaveFormat()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="SaveFormat"/>.
        /// </summary>
        /// <param name="session">Сессия.</param>
        public SaveFormat(Session session)
        {
            Session = session;
        }
    }
}