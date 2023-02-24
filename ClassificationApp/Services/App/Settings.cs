namespace ClassificationApp.Services.App
{
    /// <summary>
    /// Класс настроек с путём сохранения файла.
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Возращает и задаёт путь сохранения файла.
        /// </summary>
        public string SavePath { get; set; } = "Save.txt";

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Settings"/> по умолчанию.
        /// </summary>
        public Settings()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Settings"/>.
        /// </summary>
        /// <param name="savePath">Путь сохранения файла.</param>
        public Settings(string savePath)
        {
            SavePath = savePath;
        }
    }
}