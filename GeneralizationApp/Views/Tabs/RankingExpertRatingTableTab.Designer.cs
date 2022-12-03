namespace GeneralizationApp.Views.Tabs
{
    partial class RankingExpertRatingTableTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RankingGeneralizerControl = new GeneralizationApp.Views.Controls.RankingGeneralizerControl();
            this.RankingExpertRatingTableControl = new GeneralizationApp.Views.Controls.RankingExpertRatingTableControl();
            this.RankingExpertRatingTableGroupBox = new System.Windows.Forms.GroupBox();
            this.RankingExpertRatingTableGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RankingGeneralizerControl
            // 
            this.RankingGeneralizerControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RankingGeneralizerControl.Location = new System.Drawing.Point(0, 0);
            this.RankingGeneralizerControl.Name = "RankingGeneralizerControl";
            this.RankingGeneralizerControl.Size = new System.Drawing.Size(851, 24);
            this.RankingGeneralizerControl.TabIndex = 0;
            this.RankingGeneralizerControl.ButtonClicked += new System.EventHandler(this.RankingGeneralizerControl_ButtonClicked);
            // 
            // RankingExpertRatingTableControl
            // 
            this.RankingExpertRatingTableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RankingExpertRatingTableControl.Location = new System.Drawing.Point(3, 16);
            this.RankingExpertRatingTableControl.Name = "RankingExpertRatingTableControl";
            this.RankingExpertRatingTableControl.Size = new System.Drawing.Size(845, 405);
            this.RankingExpertRatingTableControl.TabIndex = 1;
            // 
            // RankingExpertRatingTableGroupBox
            // 
            this.RankingExpertRatingTableGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RankingExpertRatingTableGroupBox.Controls.Add(this.RankingExpertRatingTableControl);
            this.RankingExpertRatingTableGroupBox.Location = new System.Drawing.Point(0, 30);
            this.RankingExpertRatingTableGroupBox.Name = "RankingExpertRatingTableGroupBox";
            this.RankingExpertRatingTableGroupBox.Size = new System.Drawing.Size(851, 424);
            this.RankingExpertRatingTableGroupBox.TabIndex = 2;
            this.RankingExpertRatingTableGroupBox.TabStop = false;
            this.RankingExpertRatingTableGroupBox.Text = "Ranking expert rating table";
            // 
            // RankingExpertRatingTableTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RankingExpertRatingTableGroupBox);
            this.Controls.Add(this.RankingGeneralizerControl);
            this.Name = "RankingExpertRatingTableTab";
            this.Size = new System.Drawing.Size(851, 454);
            this.RankingExpertRatingTableGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RankingGeneralizerControl RankingGeneralizerControl;
        private Controls.RankingExpertRatingTableControl RankingExpertRatingTableControl;
        private System.Windows.Forms.GroupBox RankingExpertRatingTableGroupBox;
    }
}
