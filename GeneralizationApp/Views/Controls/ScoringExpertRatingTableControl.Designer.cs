namespace GeneralizationApp.Views.Controls
{
    partial class ScoringExpertRatingTableControl
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
            this.ObjectCountLabel = new System.Windows.Forms.Label();
            this.ExpertCountLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.WithCompetenciesCheckBox = new System.Windows.Forms.CheckBox();
            this.ObjectCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ExpertCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TableWeightsGridControl = new GeneralizationApp.Views.Controls.TableWeightsGridControl();
            this.ScoringTableGridControl = new GeneralizationApp.Views.Controls.ScoringTableGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpertCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectCountLabel
            // 
            this.ObjectCountLabel.AutoSize = true;
            this.ObjectCountLabel.Location = new System.Drawing.Point(120, 4);
            this.ObjectCountLabel.Name = "ObjectCountLabel";
            this.ObjectCountLabel.Size = new System.Drawing.Size(69, 13);
            this.ObjectCountLabel.TabIndex = 9;
            this.ObjectCountLabel.Text = "ObjectCount:";
            // 
            // ExpertCountLabel
            // 
            this.ExpertCountLabel.AutoSize = true;
            this.ExpertCountLabel.Location = new System.Drawing.Point(-3, 4);
            this.ExpertCountLabel.Name = "ExpertCountLabel";
            this.ExpertCountLabel.Size = new System.Drawing.Size(68, 13);
            this.ExpertCountLabel.TabIndex = 8;
            this.ExpertCountLabel.Text = "ExpertCount:";
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.Location = new System.Drawing.Point(713, -1);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // WithCompetenciesCheckBox
            // 
            this.WithCompetenciesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WithCompetenciesCheckBox.AutoSize = true;
            this.WithCompetenciesCheckBox.Location = new System.Drawing.Point(0, 334);
            this.WithCompetenciesCheckBox.Name = "WithCompetenciesCheckBox";
            this.WithCompetenciesCheckBox.Size = new System.Drawing.Size(118, 17);
            this.WithCompetenciesCheckBox.TabIndex = 11;
            this.WithCompetenciesCheckBox.Text = "With Competencies";
            this.WithCompetenciesCheckBox.UseVisualStyleBackColor = true;
            this.WithCompetenciesCheckBox.CheckedChanged += new System.EventHandler(this.WithCompetenciesCheckBox_CheckedChanged);
            // 
            // ObjectCountNumericUpDown
            // 
            this.ObjectCountNumericUpDown.Location = new System.Drawing.Point(195, 2);
            this.ObjectCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ObjectCountNumericUpDown.Name = "ObjectCountNumericUpDown";
            this.ObjectCountNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.ObjectCountNumericUpDown.TabIndex = 13;
            this.ObjectCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ObjectCountNumericUpDown.ValueChanged += new System.EventHandler(this.ObjectCountNumericUpDown_ValueChanged);
            // 
            // ExpertCountNumericUpDown
            // 
            this.ExpertCountNumericUpDown.Location = new System.Drawing.Point(71, 2);
            this.ExpertCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExpertCountNumericUpDown.Name = "ExpertCountNumericUpDown";
            this.ExpertCountNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.ExpertCountNumericUpDown.TabIndex = 12;
            this.ExpertCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExpertCountNumericUpDown.ValueChanged += new System.EventHandler(this.ExpertCountNumericUpDown_ValueChanged);
            // 
            // RatingTableWeightsGridControl
            // 
            this.TableWeightsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableWeightsGridControl.Location = new System.Drawing.Point(0, 357);
            this.TableWeightsGridControl.Name = "RatingTableWeightsGridControl";
            this.TableWeightsGridControl.Size = new System.Drawing.Size(788, 49);
            this.TableWeightsGridControl.TabIndex = 15;
            this.TableWeightsGridControl.Visible = false;
            // 
            // ScoringTableGridControl
            // 
            this.ScoringTableGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoringTableGridControl.Location = new System.Drawing.Point(0, 28);
            this.ScoringTableGridControl.Name = "ScoringTableGridControl";
            this.ScoringTableGridControl.Size = new System.Drawing.Size(788, 300);
            this.ScoringTableGridControl.TabIndex = 14;
            // 
            // ScoringExpertRatingTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableWeightsGridControl);
            this.Controls.Add(this.ScoringTableGridControl);
            this.Controls.Add(this.ObjectCountNumericUpDown);
            this.Controls.Add(this.ExpertCountNumericUpDown);
            this.Controls.Add(this.WithCompetenciesCheckBox);
            this.Controls.Add(this.ObjectCountLabel);
            this.Controls.Add(this.ExpertCountLabel);
            this.Controls.Add(this.CreateButton);
            this.Name = "ScoringExpertRatingTableControl";
            this.Size = new System.Drawing.Size(788, 406);
            ((System.ComponentModel.ISupportInitialize)(this.ObjectCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpertCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ObjectCountLabel;
        private System.Windows.Forms.Label ExpertCountLabel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.CheckBox WithCompetenciesCheckBox;
        private System.Windows.Forms.NumericUpDown ObjectCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown ExpertCountNumericUpDown;
        private ScoringTableGridControl ScoringTableGridControl;
        private TableWeightsGridControl TableWeightsGridControl;
    }
}
