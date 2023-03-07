﻿using System;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Services.IO;
using SystemAnalysisMethodApp.Services.App;

namespace SystemAnalysisMethodApp.Views.Forms
{
    /// <summary>
    /// Основное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Настройки.
        /// </summary>
        private Settings _settings = new Settings();

        /// <summary>
        /// Сессия.
        /// </summary>
        private Session _session = new Session();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/> по умолчанию.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SaveFormat save = new SaveFormat();
            try
            {
                save = JsonManager.Load<SaveFormat>(_settings.SavePath);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
            finally
            {
                _session = save == null ? _session : save.Session;
                MainTab.Countries = _session.Countries;
                MainTab.PairComparisonMatrix = _session.PairComparisonMatrix;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                SaveFormat save = new SaveFormat(_session);
                JsonManager.Save(save, _settings.SavePath);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}