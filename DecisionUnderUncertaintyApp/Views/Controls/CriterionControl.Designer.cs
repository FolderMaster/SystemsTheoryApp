namespace DecisionUnderUncertaintyApp.Views.Controls
{
    partial class CriterionControl
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
            this.EvaluateButton = new System.Windows.Forms.Button();
            this.CriterionTypeLabel = new System.Windows.Forms.Label();
            this.CoefficientLabel = new System.Windows.Forms.Label();
            this.CoefficientTextBox = new System.Windows.Forms.TextBox();
            this.CoefficientPanel = new System.Windows.Forms.Panel();
            this.CriterionTypeSelectorControl = new DecisionUnderUncertaintyApp.Views.Controls.СriterionTypeSelectorControl();
            this.CoefficientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EvaluateButton
            // 
            this.EvaluateButton.Location = new System.Drawing.Point(0, 0);
            this.EvaluateButton.Name = "EvaluateButton";
            this.EvaluateButton.Size = new System.Drawing.Size(75, 23);
            this.EvaluateButton.TabIndex = 0;
            this.EvaluateButton.Text = "Evaluate";
            this.EvaluateButton.UseVisualStyleBackColor = true;
            this.EvaluateButton.Click += new System.EventHandler(this.EvaluateButton_Click);
            // 
            // CriterionTypeLabel
            // 
            this.CriterionTypeLabel.AutoSize = true;
            this.CriterionTypeLabel.Location = new System.Drawing.Point(81, 5);
            this.CriterionTypeLabel.Name = "CriterionTypeLabel";
            this.CriterionTypeLabel.Size = new System.Drawing.Size(71, 13);
            this.CriterionTypeLabel.TabIndex = 2;
            this.CriterionTypeLabel.Text = "Criterion type:";
            // 
            // CoefficientLabel
            // 
            this.CoefficientLabel.AutoSize = true;
            this.CoefficientLabel.Location = new System.Drawing.Point(-3, 3);
            this.CoefficientLabel.Name = "CoefficientLabel";
            this.CoefficientLabel.Size = new System.Drawing.Size(60, 13);
            this.CoefficientLabel.TabIndex = 3;
            this.CoefficientLabel.Text = "Coefficient:";
            // 
            // CoefficientTextBox
            // 
            this.CoefficientTextBox.Location = new System.Drawing.Point(63, 0);
            this.CoefficientTextBox.Name = "CoefficientTextBox";
            this.CoefficientTextBox.Size = new System.Drawing.Size(100, 20);
            this.CoefficientTextBox.TabIndex = 4;
            this.CoefficientTextBox.TextChanged += new System.EventHandler(this.CoefficientTextBox_TextChanged);
            // 
            // CoefficientPanel
            // 
            this.CoefficientPanel.Controls.Add(this.CoefficientLabel);
            this.CoefficientPanel.Controls.Add(this.CoefficientTextBox);
            this.CoefficientPanel.Location = new System.Drawing.Point(285, 2);
            this.CoefficientPanel.Name = "CoefficientPanel";
            this.CoefficientPanel.Size = new System.Drawing.Size(200, 20);
            this.CoefficientPanel.TabIndex = 5;
            this.CoefficientPanel.Visible = false;
            // 
            // CriterionTypeSelectorControl
            // 
            this.CriterionTypeSelectorControl.Location = new System.Drawing.Point(158, 2);
            this.CriterionTypeSelectorControl.Name = "CriterionTypeSelectorControl";
            this.CriterionTypeSelectorControl.Size = new System.Drawing.Size(121, 21);
            this.CriterionTypeSelectorControl.TabIndex = 1;
            this.CriterionTypeSelectorControl.SelectedItemChanged += new System.EventHandler(this.CriterionTypeSelectorControl_SelectedItemChanged);
            // 
            // CriterionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CoefficientPanel);
            this.Controls.Add(this.CriterionTypeLabel);
            this.Controls.Add(this.CriterionTypeSelectorControl);
            this.Controls.Add(this.EvaluateButton);
            this.Name = "CriterionControl";
            this.Size = new System.Drawing.Size(486, 23);
            this.CoefficientPanel.ResumeLayout(false);
            this.CoefficientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EvaluateButton;
        private СriterionTypeSelectorControl CriterionTypeSelectorControl;
        private System.Windows.Forms.Label CriterionTypeLabel;
        private System.Windows.Forms.Label CoefficientLabel;
        private System.Windows.Forms.TextBox CoefficientTextBox;
        private System.Windows.Forms.Panel CoefficientPanel;
    }
}
