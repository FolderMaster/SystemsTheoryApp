namespace SystemAnalysisMethodApp.Views.Controls
{
    partial class PairComparisonMatrixControl
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
            this.MatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.Label = new System.Windows.Forms.Label();
            this.DoubleMatrixGridControl = new SystemAnalysisMethodApp.Views.Controls.DoubleMatrixGridControl();
            this.MatrixGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatrixGroupBox
            // 
            this.MatrixGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatrixGroupBox.Controls.Add(this.DoubleMatrixGridControl);
            this.MatrixGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MatrixGroupBox.Name = "MatrixGroupBox";
            this.MatrixGroupBox.Size = new System.Drawing.Size(574, 388);
            this.MatrixGroupBox.TabIndex = 0;
            this.MatrixGroupBox.TabStop = false;
            this.MatrixGroupBox.Text = "Matrix";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(-3, 469);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(0, 13);
            this.Label.TabIndex = 1;
            // 
            // DoubleMatrixGridControl
            // 
            this.DoubleMatrixGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoubleMatrixGridControl.Location = new System.Drawing.Point(3, 16);
            this.DoubleMatrixGridControl.Name = "DoubleMatrixGridControl";
            this.DoubleMatrixGridControl.Size = new System.Drawing.Size(568, 369);
            this.DoubleMatrixGridControl.TabIndex = 0;
            this.DoubleMatrixGridControl.MatrixChanged += new System.EventHandler(this.DoubleMatrixGridControl_MatrixChanged);
            // 
            // PairComparisonMatrixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label);
            this.Controls.Add(this.MatrixGroupBox);
            this.Name = "PairComparisonMatrixControl";
            this.Size = new System.Drawing.Size(574, 482);
            this.MatrixGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MatrixGroupBox;
        private DoubleMatrixGridControl DoubleMatrixGridControl;
        private System.Windows.Forms.Label Label;
    }
}
