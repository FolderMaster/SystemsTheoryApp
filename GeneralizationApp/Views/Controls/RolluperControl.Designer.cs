namespace GeneralizationApp.Views.Controls
{
    partial class RolluperControl
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
            this.RollupButton = new System.Windows.Forms.Button();
            this.RolluperTypeLabel = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RollupButton
            // 
            this.RollupButton.Location = new System.Drawing.Point(0, 0);
            this.RollupButton.Name = "RollupButton";
            this.RollupButton.Size = new System.Drawing.Size(75, 23);
            this.RollupButton.TabIndex = 5;
            this.RollupButton.Text = "Rollup";
            this.RollupButton.UseVisualStyleBackColor = true;
            this.RollupButton.Click += new System.EventHandler(this.RollupButton_Click);
            // 
            // RolluperTypeLabel
            // 
            this.RolluperTypeLabel.AutoSize = true;
            this.RolluperTypeLabel.Location = new System.Drawing.Point(81, 5);
            this.RolluperTypeLabel.Name = "RolluperTypeLabel";
            this.RolluperTypeLabel.Size = new System.Drawing.Size(72, 13);
            this.RolluperTypeLabel.TabIndex = 4;
            this.RolluperTypeLabel.Text = "Rolluper type:";
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(159, 2);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComboBox.TabIndex = 3;
            // 
            // RolluperControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RollupButton);
            this.Controls.Add(this.RolluperTypeLabel);
            this.Controls.Add(this.ComboBox);
            this.Name = "RolluperControl";
            this.Size = new System.Drawing.Size(284, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RollupButton;
        private System.Windows.Forms.Label RolluperTypeLabel;
        private System.Windows.Forms.ComboBox ComboBox;
    }
}
