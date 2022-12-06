namespace SystemAnalysisMethodApp.Views.Forms
{
    partial class FinalResultForm
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
            this.FinalResultTab = new SystemAnalysisMethodApp.Views.Tabs.FinalResultTab();
            this.SuspendLayout();
            // 
            // FinalResultTab
            // 
            this.FinalResultTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalResultTab.Location = new System.Drawing.Point(3, 3);
            this.FinalResultTab.Name = "FinalResultTab";
            this.FinalResultTab.Size = new System.Drawing.Size(655, 198);
            this.FinalResultTab.TabIndex = 0;
            // 
            // FinalResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 204);
            this.Controls.Add(this.FinalResultTab);
            this.Name = "FinalResultForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "FinalResult";
            this.ResumeLayout(false);

        }

        #endregion

        private Tabs.FinalResultTab FinalResultTab;
    }
}