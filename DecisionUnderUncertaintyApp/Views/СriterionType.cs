namespace DecisionUnderUncertaintyApp.Views.Controls
{
    /// <summary>
    /// Перечисление типов критерия нахождения наиболее оптимального решения.
    /// </summary>
    public enum СriterionType
    {
        /// <summary>
        /// Критерий Лапласа.
        /// </summary>
        LaplaceCriterion,
        /// <summary>
        /// Критерий Вальда.
        /// </summary>
        WaldCriterion,
        /// <summary>
        /// Критерий максимакса.
        /// </summary>
        MaximumCriterion,
        /// <summary>
        /// Критерий Гурвица.
        /// </summary>
        HurwitzCriterion,
        /// <summary>
        /// Критерий Сэвиджа.
        /// </summary>
        SavageCriterion
    }
}