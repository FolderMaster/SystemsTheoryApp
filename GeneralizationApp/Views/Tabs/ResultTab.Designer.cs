namespace GeneralizationApp.Views.Tabs
{
    partial class ResultTab
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
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueTableGridControl = new GeneralizationApp.Views.Controls.DoubleTableGridControl();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultGroupBox.Controls.Add(this.ValueTableGridControl);
            this.ResultGroupBox.Location = new System.Drawing.Point(0, 27);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(495, 86);
            this.ResultGroupBox.TabIndex = 0;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Result";
            // 
            // ValueTableGridControl
            // 
            this.ValueTableGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueTableGridControl.IsReadOnly = true;
            this.ValueTableGridControl.Location = new System.Drawing.Point(3, 16);
            this.ValueTableGridControl.Name = "ValueTableGridControl";
            this.ValueTableGridControl.Size = new System.Drawing.Size(489, 67);
            this.ValueTableGridControl.TabIndex = 0;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(0, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(145, 13);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "The result received by  within";
            // 
            // ResultTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultGroupBox);
            this.Name = "ResultTab";
            this.Size = new System.Drawing.Size(495, 113);
            this.ResultGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ResultGroupBox;
        private Controls.DoubleTableGridControl ValueTableGridControl;
        private System.Windows.Forms.Label ResultLabel;
    }
}
