using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ClassificationApp.Models.Countries;
using ClassificationApp.Models.Scenes;

namespace ClassificationApp.Views.Forms
{
    /// <summary>
    /// Окно для отображение результатов классифицирования.
    /// </summary>
    public partial class ResultForm : Form
    {
        /// <summary>
        /// Возращает и задаёт список стран.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Country> Countries
        {
            get => ResultTab.Result;
            set => ResultTab.Result = value;
        }

        /// <summary>
        /// Возращает и задаёт трёхмерную сцену.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Scene3D Scene3D
        {
            get => ResultTab.Scene3D;
            set => ResultTab.Scene3D = value;
        }

        /// <summary>
        /// Возращает и задаёт наименование классификатора.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ClassifierName
        {
            get => ResultTab.ClassifierName;
            set => ResultTab.ClassifierName = value;
        }

        /// <summary>
        /// Возращает и задаёт время процесса классифицирования.
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