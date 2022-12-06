namespace SystemAnalysisMethodApp.Views.Forms
{
    partial class PairComparisonForm
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
            this.PairComparisonTab = new SystemAnalysisMethodApp.Views.Tabs.PairComparisonTab();
            this.SuspendLayout();
            // 
            // PairComparisonTab
            // 
            this.PairComparisonTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PairComparisonTab.Location = new System.Drawing.Point(3, 3);
            this.PairComparisonTab.Name = "PairComparisonTab";
            this.PairComparisonTab.Size = new System.Drawing.Size(493, 278);
            this.PairComparisonTab.TabIndex = 0;
            // 
            // PairComparisonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 284);
            this.Controls.Add(this.PairComparisonTab);
            this.Name = "PairComparisonForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "PairComparison";
            this.ResumeLayout(false);

        }

        #endregion

        private Tabs.PairComparisonTab PairComparisonTab;
    }
}