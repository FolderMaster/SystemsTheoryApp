namespace GeneralizationApp.Views.Forms
{
    partial class ResultForm
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
            this.ResultTab = new GeneralizationApp.Views.Tabs.ResultTab();
            this.SuspendLayout();
            // 
            // ResultTab
            // 
            this.ResultTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTab.Location = new System.Drawing.Point(0, 0);
            this.ResultTab.Name = "ResultTab";
            this.ResultTab.Size = new System.Drawing.Size(419, 92);
            this.ResultTab.TabIndex = 0;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 92);
            this.Controls.Add(this.ResultTab);
            this.Name = "ResultForm";
            this.Text = "Result";
            this.ResumeLayout(false);

        }

        #endregion

        private Tabs.ResultTab ResultTab;
    }
}