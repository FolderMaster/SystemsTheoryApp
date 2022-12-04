namespace SystemAnalysisMethodApp.Views.Tabs
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
            this.CountriesGroupBox = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PairComparisonMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.CountryGridControl = new SystemAnalysisMethodApp.Views.Controls.CountryGridControl();
            this.PairComparisonMatrixControl = new SystemAnalysisMethodApp.Views.Controls.PairComparisonMatrixControl();
            this.CountriesGroupBox.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.PairComparisonMatrixGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountriesGroupBox
            // 
            this.CountriesGroupBox.Controls.Add(this.CountryGridControl);
            this.CountriesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountriesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CountriesGroupBox.Name = "CountriesGroupBox";
            this.CountriesGroupBox.Size = new System.Drawing.Size(285, 399);
            this.CountriesGroupBox.TabIndex = 1;
            this.CountriesGroupBox.TabStop = false;
            this.CountriesGroupBox.Text = "Countries";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.CountriesGroupBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.PairComparisonMatrixGroupBox, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(582, 405);
            this.TableLayoutPanel.TabIndex = 2;
            // 
            // PairComparisonMatrixGroupBox
            // 
            this.PairComparisonMatrixGroupBox.Controls.Add(this.PairComparisonMatrixControl);
            this.PairComparisonMatrixGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PairComparisonMatrixGroupBox.Location = new System.Drawing.Point(294, 3);
            this.PairComparisonMatrixGroupBox.Name = "PairComparisonMatrixGroupBox";
            this.PairComparisonMatrixGroupBox.Size = new System.Drawing.Size(285, 399);
            this.PairComparisonMatrixGroupBox.TabIndex = 2;
            this.PairComparisonMatrixGroupBox.TabStop = false;
            this.PairComparisonMatrixGroupBox.Text = "PairComparisonMatrix";
            // 
            // CountryGridControl
            // 
            this.CountryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountryGridControl.IsEditor = true;
            this.CountryGridControl.Location = new System.Drawing.Point(3, 16);
            this.CountryGridControl.Name = "CountryGridControl";
            this.CountryGridControl.Size = new System.Drawing.Size(279, 380);
            this.CountryGridControl.TabIndex = 0;
            // 
            // PairComparisonMatrixControl
            // 
            this.PairComparisonMatrixControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PairComparisonMatrixControl.Location = new System.Drawing.Point(3, 16);
            this.PairComparisonMatrixControl.Name = "PairComparisonMatrixControl";
            this.PairComparisonMatrixControl.Size = new System.Drawing.Size(279, 380);
            this.PairComparisonMatrixControl.TabIndex = 0;
            // 
            // MainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel);
            this.Name = "MainTab";
            this.Size = new System.Drawing.Size(582, 405);
            this.CountriesGroupBox.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.PairComparisonMatrixGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CountryGridControl CountryGridControl;
        private System.Windows.Forms.GroupBox CountriesGroupBox;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.GroupBox PairComparisonMatrixGroupBox;
        private Controls.PairComparisonMatrixControl PairComparisonMatrixControl;
    }
}
