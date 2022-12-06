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
            this.PairComparisonMatrixGridControl = new SystemAnalysisMethodApp.Views.Controls.PairComparisonMatrixGridControl();
            this.Label = new System.Windows.Forms.Label();
            this.CalculationButton = new System.Windows.Forms.Button();
            this.MatrixGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatrixGroupBox
            // 
            this.MatrixGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatrixGroupBox.Controls.Add(this.PairComparisonMatrixGridControl);
            this.MatrixGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MatrixGroupBox.Name = "MatrixGroupBox";
            this.MatrixGroupBox.Size = new System.Drawing.Size(574, 453);
            this.MatrixGroupBox.TabIndex = 0;
            this.MatrixGroupBox.TabStop = false;
            this.MatrixGroupBox.Text = "Matrix";
            // 
            // PairComparisonMatrixGridControl
            // 
            this.PairComparisonMatrixGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PairComparisonMatrixGridControl.Location = new System.Drawing.Point(3, 16);
            this.PairComparisonMatrixGridControl.Name = "PairComparisonMatrixGridControl";
            this.PairComparisonMatrixGridControl.Size = new System.Drawing.Size(568, 434);
            this.PairComparisonMatrixGridControl.TabIndex = 0;
            this.PairComparisonMatrixGridControl.MatrixChanged += new System.EventHandler(this.DoubleMatrixGridControl_MatrixChanged);
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(-3, 469);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(0, 13);
            this.Label.TabIndex = 1;
            // 
            // CalculationButton
            // 
            this.CalculationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationButton.Location = new System.Drawing.Point(499, 459);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(75, 23);
            this.CalculationButton.TabIndex = 2;
            this.CalculationButton.Text = "Calculation";
            this.CalculationButton.UseVisualStyleBackColor = true;
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            // 
            // PairComparisonMatrixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CalculationButton);
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
        private PairComparisonMatrixGridControl PairComparisonMatrixGridControl;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button CalculationButton;
    }
}
