namespace ClassificationApp.Views.Forms
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestCountryGridControl = new ClassificationApp.Views.Controls.CountryGridControl();
            this.EductaionCountryGridControl = new ClassificationApp.Views.Controls.CountryGridControl();
            this.ClassifierControl = new ClassificationApp.Views.Controls.ClassifierControl();
            this.SuspendLayout();
            // 
            // TestCountryGridControl
            // 
            this.TestCountryGridControl.Location = new System.Drawing.Point(343, 43);
            this.TestCountryGridControl.Name = "TestCountryGridControl";
            this.TestCountryGridControl.Size = new System.Drawing.Size(375, 428);
            this.TestCountryGridControl.TabIndex = 1;
            // 
            // EductaionCountryGridControl
            // 
            this.EductaionCountryGridControl.Location = new System.Drawing.Point(12, 43);
            this.EductaionCountryGridControl.Name = "EductaionCountryGridControl";
            this.EductaionCountryGridControl.Size = new System.Drawing.Size(325, 428);
            this.EductaionCountryGridControl.TabIndex = 0;
            // 
            // ClassifierControl
            // 
            this.ClassifierControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassifierControl.Location = new System.Drawing.Point(12, 12);
            this.ClassifierControl.Name = "ClassifierControl";
            this.ClassifierControl.Size = new System.Drawing.Size(706, 25);
            this.ClassifierControl.TabIndex = 2;
            this.ClassifierControl.ButtonClicked += new System.EventHandler(this.ClassifierControl_ButtonClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 483);
            this.Controls.Add(this.ClassifierControl);
            this.Controls.Add(this.TestCountryGridControl);
            this.Controls.Add(this.EductaionCountryGridControl);
            this.Name = "MainForm";
            this.Text = "ClassificationApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CountryGridControl EductaionCountryGridControl;
        private Controls.CountryGridControl TestCountryGridControl;
        private Controls.ClassifierControl ClassifierControl;
    }
}

