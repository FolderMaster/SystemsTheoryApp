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
            this.ScoringExpertRatingTableControl = new GeneralizationApp.Views.Controls.ScoringExpertRatingTableControl();
            this.ScoringExpertRatingTableGroupBox = new System.Windows.Forms.GroupBox();
            this.ScoringExpertRatingTableGroupBox.SuspendLayout();
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
            // ScoringExpertRatingTableControl
            // 
            this.ScoringExpertRatingTableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoringExpertRatingTableControl.Location = new System.Drawing.Point(3, 16);
            this.ScoringExpertRatingTableControl.Name = "ScoringExpertRatingTableControl";
            this.ScoringExpertRatingTableControl.Size = new System.Drawing.Size(751, 430);
            this.ScoringExpertRatingTableControl.TabIndex = 0;
            this.ScoringExpertRatingTableControl.WithCompetencies = false;
            // 
            // ScoringExpertRatingTableGroupBox
            // 
            this.ScoringExpertRatingTableGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoringExpertRatingTableGroupBox.Controls.Add(this.ScoringExpertRatingTableControl);
            this.ScoringExpertRatingTableGroupBox.Location = new System.Drawing.Point(0, 29);
            this.ScoringExpertRatingTableGroupBox.Name = "ScoringExpertRatingTableGroupBox";
            this.ScoringExpertRatingTableGroupBox.Size = new System.Drawing.Size(757, 449);
            this.ScoringExpertRatingTableGroupBox.TabIndex = 2;
            this.ScoringExpertRatingTableGroupBox.TabStop = false;
            this.ScoringExpertRatingTableGroupBox.Text = "Scoring expert rating table";
            // 
            // ScoringExpertRatingTableTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScoringExpertRatingTableGroupBox);
            this.Controls.Add(this.GeneralizeButton);
            this.Name = "ScoringExpertRatingTableTab";
            this.Size = new System.Drawing.Size(757, 478);
            this.ScoringExpertRatingTableGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ScoringExpertRatingTableControl ScoringExpertRatingTableControl;
        private System.Windows.Forms.Button GeneralizeButton;
        private System.Windows.Forms.GroupBox ScoringExpertRatingTableGroupBox;
    }
}
