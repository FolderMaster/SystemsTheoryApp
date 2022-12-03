namespace ClassificationApp.Views.Tabs
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.CountryGridControl = new ClassificationApp.Views.Controls.CountryGridControl();
            this.DisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.Scene3DDisplayControl = new ClassificationApp.Views.Controls.Scene3DDisplayControl();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.DisplayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.33333F));
            this.TableLayoutPanel.Controls.Add(this.ResultGroupBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.DisplayGroupBox, 1, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 16);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(870, 533);
            this.TableLayoutPanel.TabIndex = 7;
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.CountryGridControl);
            this.ResultGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(313, 527);
            this.ResultGroupBox.TabIndex = 0;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Result";
            // 
            // CountryGridControl
            // 
            this.CountryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountryGridControl.IsEditor = false;
            this.CountryGridControl.Location = new System.Drawing.Point(3, 16);
            this.CountryGridControl.Name = "CountryGridControl";
            this.CountryGridControl.Size = new System.Drawing.Size(307, 508);
            this.CountryGridControl.TabIndex = 3;
            // 
            // DisplayGroupBox
            // 
            this.DisplayGroupBox.Controls.Add(this.Scene3DDisplayControl);
            this.DisplayGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayGroupBox.Location = new System.Drawing.Point(322, 3);
            this.DisplayGroupBox.Name = "DisplayGroupBox";
            this.DisplayGroupBox.Size = new System.Drawing.Size(545, 527);
            this.DisplayGroupBox.TabIndex = 1;
            this.DisplayGroupBox.TabStop = false;
            this.DisplayGroupBox.Text = "Display";
            // 
            // Scene3DDisplayControl
            // 
            this.Scene3DDisplayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Scene3DDisplayControl.Location = new System.Drawing.Point(3, 16);
            this.Scene3DDisplayControl.Name = "Scene3DDisplayControl";
            this.Scene3DDisplayControl.Size = new System.Drawing.Size(539, 508);
            this.Scene3DDisplayControl.TabIndex = 0;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(-3, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(134, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "The result was received by";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.Location = new System.Drawing.Point(137, 0);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(0, 13);
            this.TextLabel.TabIndex = 9;
            // 
            // ResultTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.TableLayoutPanel);
            this.Name = "ResultTab";
            this.Size = new System.Drawing.Size(870, 549);
            this.TableLayoutPanel.ResumeLayout(false);
            this.ResultGroupBox.ResumeLayout(false);
            this.DisplayGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private Controls.CountryGridControl CountryGridControl;
        private System.Windows.Forms.GroupBox DisplayGroupBox;
        private Controls.Scene3DDisplayControl Scene3DDisplayControl;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label TextLabel;
    }
}
