namespace ClassificationApp.Views.Tabs
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EducationGroupBox = new System.Windows.Forms.GroupBox();
            this.TestGroupBox = new System.Windows.Forms.GroupBox();
            this.EductaionCountryGridControl = new ClassificationApp.Views.Controls.CountryGridControl();
            this.TestCountryGridControl = new ClassificationApp.Views.Controls.CountryGridControl();
            this.ClassifierControl = new ClassificationApp.Views.Controls.ClassifierControl();
            this.TableLayoutPanel.SuspendLayout();
            this.EducationGroupBox.SuspendLayout();
            this.TestGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.EducationGroupBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.TestGroupBox, 1, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 31);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(753, 524);
            this.TableLayoutPanel.TabIndex = 1;
            // 
            // EducationGroupBox
            // 
            this.EducationGroupBox.Controls.Add(this.EductaionCountryGridControl);
            this.EducationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EducationGroupBox.Location = new System.Drawing.Point(3, 3);
            this.EducationGroupBox.Name = "EducationGroupBox";
            this.EducationGroupBox.Size = new System.Drawing.Size(370, 518);
            this.EducationGroupBox.TabIndex = 2;
            this.EducationGroupBox.TabStop = false;
            this.EducationGroupBox.Text = "Education";
            // 
            // TestGroupBox
            // 
            this.TestGroupBox.Controls.Add(this.TestCountryGridControl);
            this.TestGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestGroupBox.Location = new System.Drawing.Point(379, 3);
            this.TestGroupBox.Name = "TestGroupBox";
            this.TestGroupBox.Size = new System.Drawing.Size(371, 518);
            this.TestGroupBox.TabIndex = 4;
            this.TestGroupBox.TabStop = false;
            this.TestGroupBox.Text = "Test";
            // 
            // EductaionCountryGridControl
            // 
            this.EductaionCountryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EductaionCountryGridControl.IsEditor = true;
            this.EductaionCountryGridControl.Location = new System.Drawing.Point(3, 16);
            this.EductaionCountryGridControl.Name = "EductaionCountryGridControl";
            this.EductaionCountryGridControl.Size = new System.Drawing.Size(364, 499);
            this.EductaionCountryGridControl.TabIndex = 3;
            // 
            // TestCountryGridControl
            // 
            this.TestCountryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestCountryGridControl.IsEditor = true;
            this.TestCountryGridControl.Location = new System.Drawing.Point(3, 16);
            this.TestCountryGridControl.Name = "TestCountryGridControl";
            this.TestCountryGridControl.Size = new System.Drawing.Size(365, 499);
            this.TestCountryGridControl.TabIndex = 5;
            // 
            // ClassifierControl
            // 
            this.ClassifierControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassifierControl.Location = new System.Drawing.Point(0, 0);
            this.ClassifierControl.Name = "ClassifierControl";
            this.ClassifierControl.Size = new System.Drawing.Size(753, 25);
            this.ClassifierControl.TabIndex = 0;
            this.ClassifierControl.ButtonClicked += new System.EventHandler(this.ClassifierControl_ButtonClicked);
            // 
            // MainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.ClassifierControl);
            this.Name = "MainTab";
            this.Size = new System.Drawing.Size(753, 555);
            this.TableLayoutPanel.ResumeLayout(false);
            this.EducationGroupBox.ResumeLayout(false);
            this.TestGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.GroupBox EducationGroupBox;
        private Controls.CountryGridControl EductaionCountryGridControl;
        private System.Windows.Forms.GroupBox TestGroupBox;
        private Controls.CountryGridControl TestCountryGridControl;
        private Controls.ClassifierControl ClassifierControl;
    }
}
