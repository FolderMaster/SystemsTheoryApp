namespace SystemAnalysisMethodApp.Views.Forms
{
    partial class PairComparisonCalculationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PairComparisonCalculationTab = new SystemAnalysisMethodApp.Views.Tabs.PairComparisonCalculationTab();
            this.SuspendLayout();
            // 
            // PairComparisonCalculationTab
            // 
            this.PairComparisonCalculationTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PairComparisonCalculationTab.Location = new System.Drawing.Point(3, 3);
            this.PairComparisonCalculationTab.Name = "PairComparisonCalculationTab";
            this.PairComparisonCalculationTab.Size = new System.Drawing.Size(697, 357);
            this.PairComparisonCalculationTab.TabIndex = 0;
            // 
            // PairComparisonCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 363);
            this.Controls.Add(this.PairComparisonCalculationTab);
            this.Name = "PairComparisonCalculationForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Calculation";
            this.ResumeLayout(false);

        }

        #endregion

        private Tabs.PairComparisonCalculationTab PairComparisonCalculationTab;
    }
}