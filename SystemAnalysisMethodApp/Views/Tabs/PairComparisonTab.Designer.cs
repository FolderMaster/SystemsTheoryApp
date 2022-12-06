namespace SystemAnalysisMethodApp.Views.Tabs
{
    partial class PairComparisonTab
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PairComparisonMatrixControl = new SystemAnalysisMethodApp.Views.Controls.PairComparisonMatrixControl();
            this.PairComparisonMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.PairComparisonMatrixGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(484, 281);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(0, 281);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // PairComparisonMatrixControl
            // 
            this.PairComparisonMatrixControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PairComparisonMatrixControl.Location = new System.Drawing.Point(3, 16);
            this.PairComparisonMatrixControl.Name = "PairComparisonMatrixControl";
            this.PairComparisonMatrixControl.Size = new System.Drawing.Size(553, 256);
            this.PairComparisonMatrixControl.TabIndex = 3;
            this.PairComparisonMatrixControl.PairComparisonMatrixChanged += new System.EventHandler(this.PairComparisonMatrixControl_PairComparisonMatrixChanged);
            // 
            // PairComparisonMatrixGroupBox
            // 
            this.PairComparisonMatrixGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PairComparisonMatrixGroupBox.Controls.Add(this.PairComparisonMatrixControl);
            this.PairComparisonMatrixGroupBox.Location = new System.Drawing.Point(0, 0);
            this.PairComparisonMatrixGroupBox.Name = "PairComparisonMatrixGroupBox";
            this.PairComparisonMatrixGroupBox.Size = new System.Drawing.Size(559, 275);
            this.PairComparisonMatrixGroupBox.TabIndex = 4;
            this.PairComparisonMatrixGroupBox.TabStop = false;
            this.PairComparisonMatrixGroupBox.Text = "Pair comparison matrix";
            // 
            // PairComparisonTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PairComparisonMatrixGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Name = "PairComparisonTab";
            this.Size = new System.Drawing.Size(559, 304);
            this.PairComparisonMatrixGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private Controls.PairComparisonMatrixControl PairComparisonMatrixControl;
        private System.Windows.Forms.GroupBox PairComparisonMatrixGroupBox;
    }
}
