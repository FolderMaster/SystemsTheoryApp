using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Tabs
{
    /// <summary>
    /// Элемент управления для просмотра результата обобщения.
    /// </summary>
    public partial class ResultTab : UserControl
    {
        /// <summary>
        /// Строка "Результат получен".
        /// </summary>
        private const string _resultString = "The result received by ";

        /// <summary>
        /// Строка "с".
        /// </summary>
        private const string _withinString = " within ";

        /// <summary>
        /// Наименования метода обобщения.
        /// </summary>
        private string _generalizerName = null;

        /// <summary>
        /// Время работы обобщения.
        /// </summary>
        private TimeSpan _time = new TimeSpan();

        /// <summary>
        /// Возращает и задаёт результат обобщения.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[] Result
        {
            get
            {
                int[] result = new int[ValueTableGridControl.DoubleArray.Length];
                for (int n = 0; n < result.Length; ++n)
                {
                    result[n] = (int)ValueTableGridControl.DoubleArray[n] - 1;
                }
                return result;
            }
            set
            {
                double[] result = new double[value.Length];
                for(int n = 0; n < result.Length; ++n)
                {
                    result[n] = ++value[n];
                }
                ValueTableGridControl.DoubleArray = result;
            }
        }

        /// <summary>
        /// Возращает и задаёт наименования метода обобщения.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string GeneralizerName
        {
            get => _generalizerName;
            set
            {
                _generalizerName = value;
                UpdateLabel();
            }
        }

        /// <summary>
        /// Возращает и задаёт время работы обобщения.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TimeSpan Time
        {
            get => _time;
            set
            {
                _time = value;
                UpdateLabel();
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ResultTab"/> по умолчанию.
        /// </summary>
        public ResultTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обобновляет строку метки.
        /// </summary>
        private void UpdateLabel()
        {
            ResultLabel.Text = _resultString + GeneralizerName + _withinString + Time;
        }
    }
}