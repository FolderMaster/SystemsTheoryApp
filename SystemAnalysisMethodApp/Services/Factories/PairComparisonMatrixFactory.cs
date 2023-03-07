using System;
using System.Collections.Generic;
using System.Linq;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Services.Factories
{
    /// <summary>
    /// Класс фабрики матриц парных сравнений, представляющий метод для создания матриц парных
    /// сравнений.
    /// </summary>
    public static class PairComparisonMatrixFactory
    {
        /// <summary>
        /// Преобразовывает в оценку числа.
        /// </summary>
        /// <param name="reduced">Уменьшаемое.</param>
        /// <param name="subtracted">Вычитаемое.</param>
        /// <param name="max">Максимум.</param>
        /// <param name="min">Минимум.</param>
        /// <returns>Оценка от 0 до 9.</returns>
        private static double ConvertToImportance(double reduced, double subtracted, double max,
            double min)
        {
            int result = (int)((reduced - subtracted) / (max - min) * 8);
            return result >= 0 ? 1 / (double)(result + 1) : -result + 1;
        }

        /// <summary>
        /// Преобразовывает в оценку характеристики.
        /// </summary>
        /// <param name="reduced">Уменьшаемое.</param>
        /// <param name="subtracted">Вычитаемое.</param>
        /// <returns>Оценка от 0 до 9.</returns>
        private static double ConvertToImportance(СharacterType reduced, СharacterType subtracted)
        {
            int result = reduced - subtracted;
            return result >= 0 ? result + 1 : 1 / (double)(-result + 1);
        }

        /// <summary>
        /// Создаёт матрицу парных сравнений стран по критерию.
        /// </summary>
        /// <param name="countries">Список стран.</param>
        /// <param name="criteriaIndex">Индекс критерия.</param>
        /// <returns>Мтарица парных сравнений стран по критерию.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static PairComparisonMatrix CreatePairComparisonMatrixByCountryCriteria
            (List<Country> countries, int criteriaIndex)
        {
            int count = countries.Count;
            double min = 0;
            double max = 0;
            switch (criteriaIndex)
            {
                case 0:
                    max = countries.OrderByDescending((c) => c.AverageLivingCost).FirstOrDefault().
                        AverageLivingCost;
                    min = countries.OrderBy((c) => c.AverageLivingCost).FirstOrDefault().
                        AverageLivingCost;
                    break;
                case 1:
                    max = countries.OrderByDescending((c) => c.TripPrice).FirstOrDefault().
                        TripPrice;
                    min = countries.OrderBy((c) => c.TripPrice).FirstOrDefault().TripPrice;
                    break;
            }

            PairComparisonMatrix result = new PairComparisonMatrix(new double[count, count], 
                countries.Select((c) => c.Name).ToArray());
            for(int y = 0; y < count; ++y)
            {
                for(int x = y; x < count; ++x)
                {
                    if(x == y)
                    {
                        result.Matrix[x, y] = 1;
                    }
                    else
                    {
                        double importance;
                        switch(criteriaIndex)
                        {
                            case 0: importance = ConvertToImportance(countries[y].AverageLivingCost,
                                countries[x].AverageLivingCost, max, min); break;
                            case 1: importance = ConvertToImportance(countries[y].TripPrice, 
                                countries[x].TripPrice, max, min); break;
                            case 2: importance = ConvertToImportance(countries[y].AttractionCount,
                                countries[x].AttractionCount); break;
                            case 3: importance = ConvertToImportance(countries[y].Climate,
                                countries[x].Climate); break;
                            case 4: importance = ConvertToImportance(countries[y].DevelopmentLevel,
                                countries[x].DevelopmentLevel); break;
                            case 5: importance = ConvertToImportance(countries[y].TouristPopularity,
                                countries[x].TouristPopularity); break;
                            default: throw new ArgumentException();
                        }
                        result.Matrix[y, x] = importance;
                        result.Matrix[x, y] = 1 / importance;
                    }
                }
            }
            return result;
        }
    }
}