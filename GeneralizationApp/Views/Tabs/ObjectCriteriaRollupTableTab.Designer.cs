namespace GeneralizationApp.Views.Tabs
{
    partial class ObjectCriteriaRollupTableTab
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
            this.ObjectCriteriaRollupTableControl = new GeneralizationApp.Views.Controls.ObjectCriteriaRollupTableControl();
            this.RolluperControl = new GeneralizationApp.Views.Controls.RolluperControl();
            this.SuspendLayout();
            // 
            // ObjectCriteriaRollupTableControl
            // 
            this.ObjectCriteriaRollupTableControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectCriteriaRollupTableControl.Location = new System.Drawing.Point(0, 30);
            this.ObjectCriteriaRollupTableControl.Name = "ObjectCriteriaRollupTableControl";
            this.ObjectCriteriaRollupTableControl.Size = new System.Drawing.Size(1120, 585);
            this.ObjectCriteriaRollupTableControl.TabIndex = 0;
            // 
            // RolluperControl
            // 
            this.RolluperControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RolluperControl.Location = new System.Drawing.Point(0, 0);
            this.RolluperControl.Name = "RolluperControl";
            this.RolluperControl.Size = new System.Drawing.Size(1120, 24);
            this.RolluperControl.TabIndex = 1;
            // 
            // ObjectCriteriaRollupTableTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RolluperControl);
            this.Controls.Add(this.ObjectCriteriaRollupTableControl);
            this.Name = "ObjectCriteriaRollupTableTab";
            this.Size = new System.Drawing.Size(1120, 615);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ObjectCriteriaRollupTableControl ObjectCriteriaRollupTableControl;
        private Controls.RolluperControl RolluperControl;
    }
}
