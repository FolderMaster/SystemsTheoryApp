using System.Collections.Generic;

using ClassificationApp.Models.Countries;

namespace ClassificationApp.Services.Classification
{
    public interface IClassifier
    {
        bool IsEducated { get; }

        void Educate(List<Country> list);

        List<Country> Classify(List<Country> list);
    }
}