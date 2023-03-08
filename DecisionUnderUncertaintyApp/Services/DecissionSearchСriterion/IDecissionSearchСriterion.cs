using DecisionUnderUncertaintyApp.Models;

namespace DecisionUnderUncertaintyApp.Services.DecissionSearchСriterion
{
    /// <summary>
    /// Интерфейс критериев нахождения наиболее оптимального решения, которые осуществляют оценку
    /// каждого решения, поиск лучшего решения.
    /// </summary>
    public interface IDecissionSearchСriterion
    {
        /// <summary>
        /// Осуществляет оценку каждого решения.
        /// </summary>
        /// <param name="table">Таблица вариантов и состояний среды.</param>
        /// <returns>Массив значений каждого варианта.</returns>
        double[] EvaluateDecissions(OptionsEnvironmentsTable table);

        /// <summary>
        /// Осуществляет поиск лучшего решения.
        /// </summary>
        /// <param name="array">Массив значений каждого варианта.</param>
        /// <returns>Индекс лучшего варианта.</returns>
        int SearchBestDecission(double[] array);
    }
}