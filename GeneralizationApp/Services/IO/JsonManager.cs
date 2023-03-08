﻿using Newtonsoft.Json;
using System.IO;

namespace GeneralizationApp.Services.IO
{
    /// <summary>
    /// Класс сериализации, представляющий методы Json-сериализации и десериализации данных в файл.
    /// </summary>
    public static class JsonManager
    {
        /// <summary>
        /// Загружает данные из Json-файла.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns>Объект данных, хранящийся в файле.</returns>
        public static T Load<T>(string filePath)
        {
            using (FileStream fileReader = File.Open(filePath, FileMode.OpenOrCreate,
                FileAccess.Read))
            {
                byte[] arrayBytes = new byte[fileReader.Length];
                fileReader.Read(arrayBytes, 0, arrayBytes.Length);
                string text = System.Text.Encoding.Default.GetString(arrayBytes);

                return JsonConvert.DeserializeObject<T>(text);
            }
        }

        /// <summary>
        /// Сохраняет данные в Json-файл.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="data">Данные.</param>
        /// <param name="filePath">Путь к файлу.</param>
        public static void Save<T>(T data, string filePath)
        {
            using (FileStream fileWriter = new FileStream(filePath, FileMode.Create,
                FileAccess.Write))
            {
                string text = JsonConvert.SerializeObject(data);

                byte[] arrayBytes = System.Text.Encoding.Default.GetBytes(text);
                fileWriter.Write(arrayBytes, 0, arrayBytes.Length);
            }
        }
    }
}