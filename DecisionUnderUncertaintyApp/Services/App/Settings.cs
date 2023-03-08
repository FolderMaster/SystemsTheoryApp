namespace DecisionUnderUncertaintyApp.Services.App
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
    }
}