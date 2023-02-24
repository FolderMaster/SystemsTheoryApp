using System.Collections.Generic;

using ClassificationApp.Models.Countries;

namespace ClassificationApp.Services.Classification
{
    /// <summary>
    /// Интерфейс классификатора.
    /// </summary>
    public interface IClassifier
    {
        /// <summary>
        /// Возращает логическое значение, указывающее, что обучен ли классификатор.
        /// </summary>
        bool IsEducated { get; }

        /// <summary>
        /// Обучает классификатор на примерах списка стран.
        /// </summary>
        /// <param name="list">Список стран.</param>
        void Educate(List<Country> list);

        /// <summary>
        /// Классифицирует список стран.
        /// </summary>
        /// <param name="list">Список стран.</param>
        /// <returns>Классифицированный список стран.</returns>
        List<Country> Classify(List<Country> list);
    }
}