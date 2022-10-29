using ClassificationApp.Models;

namespace ClassificationApp.Services.App
{
    public class SaveFormat
    {
        public Session Session { get; set; } = new Session();

        public SaveFormat()
        {
        }

        public SaveFormat(Session session)
        {
            Session = session;
        }
    }
}