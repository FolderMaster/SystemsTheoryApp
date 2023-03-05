namespace GeneralizationApp.Views.Controls
{
    /// <summary>
    /// Перечисление типа метода свёртки для таблиц оценок альтернатив.
    /// </summary>
    public enum RolluperType
    {
        /// <summary>
        /// Метод аддитивной свёртки.
        /// </summary>
        AdditiveRolluper,
        /// <summary>
        /// Метод мультипликативной свёртки.
        /// </summary>
        MultiplicativeRolluper,
        /// <summary>
        /// Метод идеальной точки.
        /// </summary>
        IdealPointRolluper
    }
}