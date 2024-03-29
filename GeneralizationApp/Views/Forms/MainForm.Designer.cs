﻿namespace GeneralizationApp.Views.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.RankingExpertRatingTableTabPage = new System.Windows.Forms.TabPage();
            this.RankingExpertRatingTableTab = new GeneralizationApp.Views.Tabs.RankingExpertRatingTableTab();
            this.ScoringExpertRatingTableTabPage = new System.Windows.Forms.TabPage();
            this.ScoringExpertRatingTableTab = new GeneralizationApp.Views.Tabs.ScoringExpertRatingTableTab();
            this.ObjectCriteriaRollupTableTabPage = new System.Windows.Forms.TabPage();
            this.ObjectCriteriaTableTab = new GeneralizationApp.Views.Tabs.ObjectCriteriaTableTab();
            this.TabControl.SuspendLayout();
            this.RankingExpertRatingTableTabPage.SuspendLayout();
            this.ScoringExpertRatingTableTabPage.SuspendLayout();
            this.ObjectCriteriaRollupTableTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.RankingExpertRatingTableTabPage);
            this.TabControl.Controls.Add(this.ScoringExpertRatingTableTabPage);
            this.TabControl.Controls.Add(this.ObjectCriteriaRollupTableTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 0;
            // 
            // RankingExpertRatingTableTabPage
            // 
            this.RankingExpertRatingTableTabPage.Controls.Add(this.RankingExpertRatingTableTab);
            this.RankingExpertRatingTableTabPage.Location = new System.Drawing.Point(4, 22);
            this.RankingExpertRatingTableTabPage.Name = "RankingExpertRatingTableTabPage";
            this.RankingExpertRatingTableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RankingExpertRatingTableTabPage.Size = new System.Drawing.Size(792, 424);
            this.RankingExpertRatingTableTabPage.TabIndex = 0;
            this.RankingExpertRatingTableTabPage.Text = "Ranking expert rating table";
            this.RankingExpertRatingTableTabPage.UseVisualStyleBackColor = true;
            // 
            // RankingExpertRatingTableTab
            // 
            this.RankingExpertRatingTableTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RankingExpertRatingTableTab.Location = new System.Drawing.Point(3, 3);
            this.RankingExpertRatingTableTab.Name = "RankingExpertRatingTableTab";
            this.RankingExpertRatingTableTab.Size = new System.Drawing.Size(786, 418);
            this.RankingExpertRatingTableTab.TabIndex = 0;
            // 
            // ScoringExpertRatingTableTabPage
            // 
            this.ScoringExpertRatingTableTabPage.Controls.Add(this.ScoringExpertRatingTableTab);
            this.ScoringExpertRatingTableTabPage.Location = new System.Drawing.Point(4, 22);
            this.ScoringExpertRatingTableTabPage.Name = "ScoringExpertRatingTableTabPage";
            this.ScoringExpertRatingTableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ScoringExpertRatingTableTabPage.Size = new System.Drawing.Size(792, 424);
            this.ScoringExpertRatingTableTabPage.TabIndex = 1;
            this.ScoringExpertRatingTableTabPage.Text = "Scoring expert rating table";
            this.ScoringExpertRatingTableTabPage.UseVisualStyleBackColor = true;
            // 
            // ScoringExpertRatingTableTab
            // 
            this.ScoringExpertRatingTableTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoringExpertRatingTableTab.Location = new System.Drawing.Point(3, 3);
            this.ScoringExpertRatingTableTab.Name = "ScoringExpertRatingTableTab";
            this.ScoringExpertRatingTableTab.Size = new System.Drawing.Size(786, 418);
            this.ScoringExpertRatingTableTab.TabIndex = 0;
            // 
            // ObjectCriteriaRollupTableTabPage
            // 
            this.ObjectCriteriaRollupTableTabPage.Controls.Add(this.ObjectCriteriaTableTab);
            this.ObjectCriteriaRollupTableTabPage.Location = new System.Drawing.Point(4, 22);
            this.ObjectCriteriaRollupTableTabPage.Name = "ObjectCriteriaRollupTableTabPage";
            this.ObjectCriteriaRollupTableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ObjectCriteriaRollupTableTabPage.Size = new System.Drawing.Size(792, 424);
            this.ObjectCriteriaRollupTableTabPage.TabIndex = 2;
            this.ObjectCriteriaRollupTableTabPage.Text = "Object criteria table";
            this.ObjectCriteriaRollupTableTabPage.UseVisualStyleBackColor = true;
            // 
            // ObjectCriteriaTableTab
            // 
            this.ObjectCriteriaTableTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectCriteriaTableTab.Location = new System.Drawing.Point(3, 3);
            this.ObjectCriteriaTableTab.Name = "ObjectCriteriaTableTab";
            this.ObjectCriteriaTableTab.Size = new System.Drawing.Size(786, 418);
            this.ObjectCriteriaTableTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "GeneralizationApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.RankingExpertRatingTableTabPage.ResumeLayout(false);
            this.ScoringExpertRatingTableTabPage.ResumeLayout(false);
            this.ObjectCriteriaRollupTableTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage RankingExpertRatingTableTabPage;
        private System.Windows.Forms.TabPage ScoringExpertRatingTableTabPage;
        private Tabs.RankingExpertRatingTableTab RankingExpertRatingTableTab;
        private Tabs.ScoringExpertRatingTableTab ScoringExpertRatingTableTab;
        private System.Windows.Forms.TabPage ObjectCriteriaRollupTableTabPage;
        private Tabs.ObjectCriteriaTableTab ObjectCriteriaTableTab;
    }
}

