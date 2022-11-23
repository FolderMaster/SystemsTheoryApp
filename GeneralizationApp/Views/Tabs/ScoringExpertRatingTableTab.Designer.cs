namespace GeneralizationApp.Views.Tabs
{
    partial class ScoringExpertRatingTableTab
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
            this.GeneralizeButton = new System.Windows.Forms.Button();
            this.scoringExpertRatingTableControl1 = new GeneralizationApp.Views.Controls.ScoringExpertRatingTableControl();
            this.SuspendLayout();
            // 
            // GeneralizeButton
            // 
            this.GeneralizeButton.Location = new System.Drawing.Point(0, 0);
            this.GeneralizeButton.Name = "GeneralizeButton";
            this.GeneralizeButton.Size = new System.Drawing.Size(75, 23);
            this.GeneralizeButton.TabIndex = 1;
            this.GeneralizeButton.Text = "Generalize";
            this.GeneralizeButton.UseVisualStyleBackColor = true;
            this.GeneralizeButton.Click += new System.EventHandler(this.GeneralizeButton_Click);
            // 
            // scoringExpertRatingTableControl1
            // 
            this.scoringExpertRatingTableControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoringExpertRatingTableControl1.Location = new System.Drawing.Point(0, 29);
            this.scoringExpertRatingTableControl1.Name = "scoringExpertRatingTableControl1";
            this.scoringExpertRatingTableControl1.Size = new System.Drawing.Size(757, 449);
            this.scoringExpertRatingTableControl1.TabIndex = 0;
            // 
            // ScoringExpertRatingTableTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GeneralizeButton);
            this.Controls.Add(this.scoringExpertRatingTableControl1);
            this.Name = "ScoringExpertRatingTableTab";
            this.Size = new System.Drawing.Size(757, 478);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ScoringExpertRatingTableControl scoringExpertRatingTableControl1;
        private System.Windows.Forms.Button GeneralizeButton;
    }
}
