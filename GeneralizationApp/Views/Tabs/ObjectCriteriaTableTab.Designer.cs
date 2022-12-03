namespace GeneralizationApp.Views.Tabs
{
    partial class ObjectCriteriaTableTab
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
            this.ObjectCriteriaTableControl = new GeneralizationApp.Views.Controls.ObjectCriteriaTableControl();
            this.RolluperControl = new GeneralizationApp.Views.Controls.RolluperControl();
            this.ObjectCriteriaTableGroupBox = new System.Windows.Forms.GroupBox();
            this.ObjectCriteriaTableGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObjectCriteriaTableControl
            // 
            this.ObjectCriteriaTableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectCriteriaTableControl.Location = new System.Drawing.Point(3, 16);
            this.ObjectCriteriaTableControl.Name = "ObjectCriteriaTableControl";
            this.ObjectCriteriaTableControl.Size = new System.Drawing.Size(1114, 566);
            this.ObjectCriteriaTableControl.TabIndex = 0;
            // 
            // RolluperControl
            // 
            this.RolluperControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RolluperControl.Location = new System.Drawing.Point(0, 0);
            this.RolluperControl.Name = "RolluperControl";
            this.RolluperControl.Size = new System.Drawing.Size(1120, 24);
            this.RolluperControl.TabIndex = 1;
            this.RolluperControl.ButtonClicked += new System.EventHandler(this.RolluperControl_ButtonClicked);
            // 
            // ObjectCriteriaTableGroupBox
            // 
            this.ObjectCriteriaTableGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectCriteriaTableGroupBox.Controls.Add(this.ObjectCriteriaTableControl);
            this.ObjectCriteriaTableGroupBox.Location = new System.Drawing.Point(0, 30);
            this.ObjectCriteriaTableGroupBox.Name = "ObjectCriteriaTableGroupBox";
            this.ObjectCriteriaTableGroupBox.Size = new System.Drawing.Size(1120, 585);
            this.ObjectCriteriaTableGroupBox.TabIndex = 2;
            this.ObjectCriteriaTableGroupBox.TabStop = false;
            this.ObjectCriteriaTableGroupBox.Text = "Object criteria table";
            // 
            // ObjectCriteriaTableTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ObjectCriteriaTableGroupBox);
            this.Controls.Add(this.RolluperControl);
            this.Name = "ObjectCriteriaTableTab";
            this.Size = new System.Drawing.Size(1120, 615);
            this.ObjectCriteriaTableGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ObjectCriteriaTableControl ObjectCriteriaTableControl;
        private Controls.RolluperControl RolluperControl;
        private System.Windows.Forms.GroupBox ObjectCriteriaTableGroupBox;
    }
}
