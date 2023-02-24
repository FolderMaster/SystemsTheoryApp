using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ClassificationApp.Models.Countries;
using ClassificationApp.Models.Scenes;
using ClassificationApp.Views.Controls;

namespace ClassificationApp.Views.Tabs
{
    /// <summary>
    /// Элемент управления для отображения результата классификации.
    /// </summary>
    public partial class ResultTab : UserControl
    {
        /// <summary>
        /// Наименование классификатора.
        /// </summary>
        private string _classifierName = null;

        /// <summary>
        /// Время процесса классифицирования.
        /// </summary>
        private TimeSpan _time = new TimeSpan();

        /// <summary>
        /// Возращает и задаёт список стран.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Country> Result
        {
            get => CountryGridControl.Countries;
            set => CountryGridControl.Countries = value;
        }

        /// <summary>
        /// Возращает и задаёт трёхмерную сцену.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Scene3D Scene3D
        {
            get => Scene3DDisplayControl.Scene3D;
            set => Scene3DDisplayControl.Scene3D = value;
        }

        /// <summary>
        /// Возращает и задаёт наименование классификатора.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ClassifierName
        {
            get => _classifierName;
            set
            {
                _classifierName = value;
                UpdateLabel();
            }
        }

        /// <summary>
        /// Возращает и задаёт время процесса классифицирования.
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
        /// Обновляет метку с временем и наименованием.
        /// </summary>
        private void UpdateLabel()
        {
            ResultLabel.Text = $"The result was received by {ClassifierName} within {Time}";
        }
    }
}