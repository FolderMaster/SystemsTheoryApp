using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Forms
{
    /// <summary>
    /// Окно приложения для отображения результатов обобщения.
    /// </summary>
    public partial class ResultForm : Form
    {
        /// <summary>
        /// Возращает и задаёт результат обобщения.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[] Result
        {
            get => ResultTab.Result;
            set => ResultTab.Result = value;
        }

        /// <summary>
        /// Возращает и задаёт наименования метода обобщения.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string GeneralizerName
        {
            get => ResultTab.GeneralizerName;
            set => ResultTab.GeneralizerName = value;
        }

        /// <summary>
        /// Возращает и задаёт время работы обобщения.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TimeSpan Time
        {
            get => ResultTab.Time;
            set => ResultTab.Time = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ResultForm"/> по умолчанию.
        /// </summary>
        public ResultForm()
        {
            InitializeComponent();
        }
    }
}