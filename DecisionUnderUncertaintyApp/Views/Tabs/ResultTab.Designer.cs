namespace DecisionUnderUncertaintyApp.Views.Tabs
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
            this.DoubleArrayControl = new DecisionUnderUncertaintyApp.Views.Controls.DoubleArrayControl();
            this.SuspendLayout();
            // 
            // DoubleArrayControl
            // 
            this.DoubleArrayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoubleArrayControl.Location = new System.Drawing.Point(0, 0);
            this.DoubleArrayControl.Name = "DoubleArrayControl";
            this.DoubleArrayControl.Size = new System.Drawing.Size(610, 304);
            this.DoubleArrayControl.TabIndex = 0;
            // 
            // ResultTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DoubleArrayControl);
            this.Name = "ResultTab";
            this.Size = new System.Drawing.Size(610, 304);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DoubleArrayControl DoubleArrayControl;
    }
}
