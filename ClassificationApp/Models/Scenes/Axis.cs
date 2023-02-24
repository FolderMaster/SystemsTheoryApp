namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Класс оси, которая хранит максимум, минимум, методы для работы с ним, интерфейс
    /// масштабирования и длину.
    /// </summary>
    public class Axis
    {
        /// <summary>
        /// Делегат для методов работы с макисмумом/минимумом.
        /// </summary>
        /// <param name="a">Макисмум/минимум.</param>
        /// <returns>Новый макисмум/минимум.</returns>
        public delegate double Function(double a);

        /// <summary>
        /// Возращает и задаёт интерфейс масштабирования.
        /// </summary>
        public IScale Scale { get; set; } = new LinearScale();

        /// <summary>
        /// Возращает и задаёт минимум.
        /// </summary>
        public double Min { get; set; } = 0;

        /// <summary>
        /// Возращает и задаёт максимум.
        /// </summary>
        public double Max { get; set; } = 0;

        /// <summary>
        /// Возращает и задаёт длину.
        /// </summary>
        public double Length { get; set; } = 0;

        /// <summary>
        /// Возращает и задаёт делегат для работы с минимумом.
        /// </summary>
        public Function MinFunction { get; set; } = (a) => a;

        /// <summary>
        /// Возращает и задаёт делегат для работы с максимумом.
        /// </summary>
        public Function MaxFunction { get; set; } = (a) => a;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Axis"/> по умолчанию.
        /// </summary>
        public Axis()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Axis"/>.
        /// </summary>
        /// <param name="lenght">Длина.</param>
        /// <param name="min">Минимум.</param>
        /// <param name="max">Максимум.</param>
        public Axis(double lenght = 0, double min = 0, double max = 0)
        {
            Length = lenght;
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Axis"/>.
        /// </summary>
        /// <param name="scale">Интерфейс масштабирования.</param>
        /// <param name="lenght">Длина.</param>
        /// <param name="min">Минимум.</param>
        /// <param name="max">Максимум.</param>
        public Axis(IScale scale, double lenght = 0, double min = 0, double max = 0)
        {
            Scale = scale;
            Length = lenght;
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Axis"/>.
        /// </summary>
        /// <param name="scale">Интерфейс масштабирования.</param>
        /// <param name="minFunction">Делегат для работы с минимумом.</param>
        /// <param name="maxFunction">Делегат для работы с максимумом.</param>
        /// <param name="lenght">Длина.</param>
        /// <param name="min">Минимум.</param>
        /// <param name="max">Максимум.</param>
        public Axis(IScale scale, Function minFunction, Function maxFunction, double lenght = 0,
            double min = 0, double max = 0)
        {
            Scale = scale;
            Length = lenght;
            Min = min;
            Max = max;
            MinFunction = minFunction;
            MaxFunction = maxFunction;
        }

        /// <summary>
        /// Производит отображение координаты на оси.
        /// </summary>
        /// <param name="value">Некоторая координата.</param>
        /// <returns>Отображенная координата.</returns>
        public double Display(double value)
        {
            return Scale.Display(value, Min, Max, Length);
        }
    }
}