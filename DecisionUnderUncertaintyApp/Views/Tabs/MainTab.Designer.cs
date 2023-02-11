namespace DecisionUnderUncertaintyApp.Views.Tabs
{
    partial class MainTab
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
            this.OptionsEnvironmentsTableControl = new DecisionUnderUncertaintyApp.Views.Controls.OptionsEnvironmentsTableControl();
            this.CriterionControl = new DecisionUnderUncertaintyApp.Views.Controls.CriterionControl();
            this.SuspendLayout();
            // 
            // OptionsEnvironmentsTableControl
            // 
            this.OptionsEnvironmentsTableControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsEnvironmentsTableControl.Location = new System.Drawing.Point(0, 29);
            this.OptionsEnvironmentsTableControl.Name = "OptionsEnvironmentsTableControl";
            this.OptionsEnvironmentsTableControl.Size = new System.Drawing.Size(788, 427);
            this.OptionsEnvironmentsTableControl.TabIndex = 0;
            // 
            // CriterionControl
            // 
            this.CriterionControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CriterionControl.Location = new System.Drawing.Point(0, 0);
            this.CriterionControl.Name = "CriterionControl";
            this.CriterionControl.Size = new System.Drawing.Size(788, 23);
            this.CriterionControl.TabIndex = 1;
            this.CriterionControl.ButtonClicked += new System.EventHandler(this.CriterionControl_ButtonClicked);
            // 
            // MainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CriterionControl);
            this.Controls.Add(this.OptionsEnvironmentsTableControl);
            this.Name = "MainTab";
            this.Size = new System.Drawing.Size(788, 456);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.OptionsEnvironmentsTableControl OptionsEnvironmentsTableControl;
        private Controls.CriterionControl CriterionControl;
    }
}
