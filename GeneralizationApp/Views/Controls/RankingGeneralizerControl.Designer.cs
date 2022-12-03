namespace GeneralizationApp.Views.Controls
{
    partial class RankingGeneralizerControl
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
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.GeneralizationTypeLabel = new System.Windows.Forms.Label();
            this.GeneralizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(187, 2);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComboBox.TabIndex = 0;
            // 
            // GeneralizationTypeLabel
            // 
            this.GeneralizationTypeLabel.AutoSize = true;
            this.GeneralizationTypeLabel.Location = new System.Drawing.Point(81, 5);
            this.GeneralizationTypeLabel.Name = "GeneralizationTypeLabel";
            this.GeneralizationTypeLabel.Size = new System.Drawing.Size(100, 13);
            this.GeneralizationTypeLabel.TabIndex = 1;
            this.GeneralizationTypeLabel.Text = "Generalization type:";
            // 
            // GeneralizeButton
            // 
            this.GeneralizeButton.Location = new System.Drawing.Point(0, 0);
            this.GeneralizeButton.Name = "GeneralizeButton";
            this.GeneralizeButton.Size = new System.Drawing.Size(75, 23);
            this.GeneralizeButton.TabIndex = 2;
            this.GeneralizeButton.Text = "Generalize";
            this.GeneralizeButton.UseVisualStyleBackColor = true;
            this.GeneralizeButton.Click += new System.EventHandler(this.GeneralizeButton_Click);
            // 
            // RankingGeneralizerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GeneralizeButton);
            this.Controls.Add(this.GeneralizationTypeLabel);
            this.Controls.Add(this.ComboBox);
            this.Name = "RankingGeneralizerControl";
            this.Size = new System.Drawing.Size(311, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label GeneralizationTypeLabel;
        private System.Windows.Forms.Button GeneralizeButton;
    }
}
