﻿using System.Collections.Generic;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Services.Factories
{
    /// <summary>
    /// Класс фабрики таблиц оценок альтернатив, представляющий метод для создания таблиц оценок
    /// альтернатив.
    /// </summary>
    public static class ObjectCriteriaTableFactory
    {
        /// <summary>
        /// Создаёт таблицу оценок альтернатив на основе матриц парных сравнений.
        /// </summary>
        /// <param name="pairComparisonMatrices">Матрицы парных сравнений.</param>
        /// <returns>Матрица парных сравнений на основе матриц парных сравнений.</returns>
        public static ObjectCriteriaTable CreateObjectCriteriaTableByPairComparisonMatrix
            (List<PairComparisonMatrix> pairComparisonMatrices)
        {
            ObjectCriteriaTable result = new ObjectCriteriaTable();

            result.CriteriaNames = pairComparisonMatrices[0].Names;
            double[] weightMatrix = new double[pairComparisonMatrices[0].Count];
            for(int x = 0; x < pairComparisonMatrices[0].Count; ++x)
            {
                weightMatrix[x] = pairComparisonMatrices[0].GetNormalizedVector(x);
            }
            result.WeightMatrix = weightMatrix;

            for (int n = 1; n < pairComparisonMatrices.Count; ++n)
            {
                if(n == 1)
                {
                    result.AlternativeNames = pairComparisonMatrices[n].Names;
                    result.TableMatrix = new double[pairComparisonMatrices[n].Count, 
                        pairComparisonMatrices[0].Count];
                }
                for (int y = 0; y < pairComparisonMatrices[n].Count; ++y)
                {
                    result.TableMatrix[y, n - 1] = pairComparisonMatrices[n].GetNormalizedVector(y);
                }
            }

            return result;
        }
    }
}