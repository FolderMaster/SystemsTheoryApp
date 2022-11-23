namespace GeneralizationApp.Views.Controls
{
    partial class RankingExpertRatingTableControl
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.ExpertCountLabel = new System.Windows.Forms.Label();
            this.ObjectCountLabel = new System.Windows.Forms.Label();
            this.RankingExpertRatingTableGridControl = new GeneralizationApp.Views.Controls.RankingExpertRatingTableGridControl();
            this.ExpertCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ObjectCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ExpertCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.Location = new System.Drawing.Point(665, 0);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ExpertCountLabel
            // 
            this.ExpertCountLabel.AutoSize = true;
            this.ExpertCountLabel.Location = new System.Drawing.Point(-3, 5);
            this.ExpertCountLabel.Name = "ExpertCountLabel";
            this.ExpertCountLabel.Size = new System.Drawing.Size(68, 13);
            this.ExpertCountLabel.TabIndex = 3;
            this.ExpertCountLabel.Text = "ExpertCount:";
            // 
            // ObjectCountLabel
            // 
            this.ObjectCountLabel.AutoSize = true;
            this.ObjectCountLabel.Location = new System.Drawing.Point(120, 5);
            this.ObjectCountLabel.Name = "ObjectCountLabel";
            this.ObjectCountLabel.Size = new System.Drawing.Size(69, 13);
            this.ObjectCountLabel.TabIndex = 4;
            this.ObjectCountLabel.Text = "ObjectCount:";
            // 
            // RankingExpertRatingTableGridControl
            // 
            this.RankingExpertRatingTableGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RankingExpertRatingTableGridControl.Location = new System.Drawing.Point(0, 29);
            this.RankingExpertRatingTableGridControl.Name = "RankingExpertRatingTableGridControl";
            this.RankingExpertRatingTableGridControl.Size = new System.Drawing.Size(740, 395);
            this.RankingExpertRatingTableGridControl.TabIndex = 5;
            // 
            // ExpertCountNumericUpDown
            // 
            this.ExpertCountNumericUpDown.Location = new System.Drawing.Point(71, 3);
            this.ExpertCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExpertCountNumericUpDown.Name = "ExpertCountNumericUpDown";
            this.ExpertCountNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.ExpertCountNumericUpDown.TabIndex = 0;
            this.ExpertCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExpertCountNumericUpDown.ValueChanged += new System.EventHandler(this.ExpertCountNumericUpDown_ValueChanged);
            // 
            // ObjectCountNumericUpDown
            // 
            this.ObjectCountNumericUpDown.Location = new System.Drawing.Point(195, 3);
            this.ObjectCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ObjectCountNumericUpDown.Name = "ObjectCountNumericUpDown";
            this.ObjectCountNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.ObjectCountNumericUpDown.TabIndex = 1;
            this.ObjectCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ObjectCountNumericUpDown.ValueChanged += new System.EventHandler(this.ObjectCountNumericUpDown_ValueChanged);
            // 
            // RankingExpertRatingTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RankingExpertRatingTableGridControl);
            this.Controls.Add(this.ObjectCountLabel);
            this.Controls.Add(this.ExpertCountLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ObjectCountNumericUpDown);
            this.Controls.Add(this.ExpertCountNumericUpDown);
            this.Name = "RankingExpertRatingTableControl";
            this.Size = new System.Drawing.Size(740, 424);
            ((System.ComponentModel.ISupportInitialize)(this.ExpertCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label ExpertCountLabel;
        private System.Windows.Forms.Label ObjectCountLabel;
        private RankingExpertRatingTableGridControl RankingExpertRatingTableGridControl;
        private System.Windows.Forms.NumericUpDown ExpertCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown ObjectCountNumericUpDown;
    }
}
