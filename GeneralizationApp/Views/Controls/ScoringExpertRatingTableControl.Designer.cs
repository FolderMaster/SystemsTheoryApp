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
            this.CompetenceTableGridControl = new GeneralizationApp.Views.Controls.DoubleTableGridControl();
            this.ScoringTableGridControl = new GeneralizationApp.Views.Controls.ScoringTableGridControl();
            this.TableGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpertCountNumericUpDown)).BeginInit();
            this.TableGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObjectCountLabel
            // 
            this.ObjectCountLabel.AutoSize = true;
            this.ObjectCountLabel.Location = new System.Drawing.Point(122, 4);
            this.ObjectCountLabel.Name = "ObjectCountLabel";
            this.ObjectCountLabel.Size = new System.Drawing.Size(71, 13);
            this.ObjectCountLabel.TabIndex = 9;
            this.ObjectCountLabel.Text = "Object count:";
            // 
            // ExpertCountLabel
            // 
            this.ExpertCountLabel.AutoSize = true;
            this.ExpertCountLabel.Location = new System.Drawing.Point(-3, 4);
            this.ExpertCountLabel.Name = "ExpertCountLabel";
            this.ExpertCountLabel.Size = new System.Drawing.Size(70, 13);
            this.ExpertCountLabel.TabIndex = 8;
            this.ExpertCountLabel.Text = "Expert count:";
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
            this.WithCompetenciesCheckBox.Size = new System.Drawing.Size(117, 17);
            this.WithCompetenciesCheckBox.TabIndex = 11;
            this.WithCompetenciesCheckBox.Text = "With competencies";
            this.WithCompetenciesCheckBox.UseVisualStyleBackColor = true;
            this.WithCompetenciesCheckBox.CheckedChanged += new System.EventHandler(this.WithCompetenciesCheckBox_CheckedChanged);
            // 
            // ObjectCountNumericUpDown
            // 
            this.ObjectCountNumericUpDown.Location = new System.Drawing.Point(199, 2);
            this.ObjectCountNumericUpDown.Name = "ObjectCountNumericUpDown";
            this.ObjectCountNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.ObjectCountNumericUpDown.TabIndex = 13;
            this.ObjectCountNumericUpDown.ValueChanged += new System.EventHandler(this.ObjectCountNumericUpDown_ValueChanged);
            // 
            // ExpertCountNumericUpDown
            // 
            this.ExpertCountNumericUpDown.Location = new System.Drawing.Point(73, 2);
            this.ExpertCountNumericUpDown.Name = "ExpertCountNumericUpDown";
            this.ExpertCountNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.ExpertCountNumericUpDown.TabIndex = 12;
            this.ExpertCountNumericUpDown.ValueChanged += new System.EventHandler(this.ExpertCountNumericUpDown_ValueChanged);
            // 
            // CompetenceTableGridControl
            // 
            this.CompetenceTableGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompetenceTableGridControl.IsReadOnly = false;
            this.CompetenceTableGridControl.Location = new System.Drawing.Point(0, 357);
            this.CompetenceTableGridControl.Name = "CompetenceTableGridControl";
            this.CompetenceTableGridControl.Size = new System.Drawing.Size(788, 49);
            this.CompetenceTableGridControl.TabIndex = 15;
            this.CompetenceTableGridControl.Visible = false;
            // 
            // ScoringTableGridControl
            // 
            this.ScoringTableGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoringTableGridControl.Location = new System.Drawing.Point(3, 16);
            this.ScoringTableGridControl.Name = "ScoringTableGridControl";
            this.ScoringTableGridControl.Size = new System.Drawing.Size(782, 281);
            this.ScoringTableGridControl.TabIndex = 14;
            // 
            // TableGroupBox
            // 
            this.TableGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableGroupBox.Controls.Add(this.ScoringTableGridControl);
            this.TableGroupBox.Location = new System.Drawing.Point(0, 28);
            this.TableGroupBox.Name = "TableGroupBox";
            this.TableGroupBox.Size = new System.Drawing.Size(788, 300);
            this.TableGroupBox.TabIndex = 16;
            this.TableGroupBox.TabStop = false;
            this.TableGroupBox.Text = "Table";
            // 
            // ScoringExpertRatingTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableGroupBox);
            this.Controls.Add(this.CompetenceTableGridControl);
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
            this.TableGroupBox.ResumeLayout(false);
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
        private DoubleTableGridControl CompetenceTableGridControl;
        private System.Windows.Forms.GroupBox TableGroupBox;
    }
}
