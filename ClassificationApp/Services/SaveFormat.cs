using ClassificationApp.Models;

namespace ClassificationApp.Services
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