using System.IO;
using Newtonsoft.Json;

namespace SystemAnalysisMethodApp.Services.IO
{
    public static class JsonManager
    {
        public static T Load<T>(string filePath)
        {
            using (FileStream fileReader = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] arrayBytes = new byte[fileReader.Length];
                fileReader.Read(arrayBytes, 0, arrayBytes.Length);
                string text = System.Text.Encoding.Default.GetString(arrayBytes);

                return JsonConvert.DeserializeObject<T>(text);
            }
        }

        public static void Save<T>(T data, string filePath)
        {
            using (FileStream fileWriter = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                string text = JsonConvert.SerializeObject(data);

                byte[] arrayBytes = System.Text.Encoding.Default.GetBytes(text);
                fileWriter.Write(arrayBytes, 0, arrayBytes.Length);
            }
        }
    }
}