namespace GeneralizationApp.Views.Controls
{
    partial class ObjectCriteriaTableControl
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
            this.WeightTableGridControl = new GeneralizationApp.Views.Controls.DoubleTableGridControl();
            this.ScoringTableGridControl = new GeneralizationApp.Views.Controls.ScoringTableGridControl();
            this.ObjectCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CriteriaCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ObjectCountLabel = new System.Windows.Forms.Label();
            this.CriteriaCountLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DecreasingCriteriaTableGridControl = new GeneralizationApp.Views.Controls.BoolTableGridControl();
            this.DecreasingCriteriaGroupBox = new System.Windows.Forms.GroupBox();
            this.TableGroupBox = new System.Windows.Forms.GroupBox();
            this.WithWeightsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaCountNumericUpDown)).BeginInit();
            this.DecreasingCriteriaGroupBox.SuspendLayout();
            this.TableGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeightTableGridControl
            // 
            this.WeightTableGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTableGridControl.IsReadOnly = false;
            this.WeightTableGridControl.Location = new System.Drawing.Point(0, 467);
            this.WeightTableGridControl.Name = "WeightTableGridControl";
            this.WeightTableGridControl.Size = new System.Drawing.Size(687, 51);
            this.WeightTableGridControl.TabIndex = 23;
            // 
            // ScoringTableGridControl
            // 
            this.ScoringTableGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoringTableGridControl.Location = new System.Drawing.Point(3, 16);
            this.ScoringTableGridControl.Name = "ScoringTableGridControl";
            this.ScoringTableGridControl.Size = new System.Drawing.Size(681, 314);
            this.ScoringTableGridControl.TabIndex = 22;
            // 
            // ObjectCountNumericUpDown
            // 
            this.ObjectCountNumericUpDown.Location = new System.Drawing.Point(74, 3);
            this.ObjectCountNumericUpDown.Name = "ObjectCountNumericUpDown";
            this.ObjectCountNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.ObjectCountNumericUpDown.TabIndex = 21;
            this.ObjectCountNumericUpDown.ValueChanged += new System.EventHandler(this.ObjectCountNumericUpDown_ValueChanged);
            // 
            // CriteriaCountNumericUpDown
            // 
            this.CriteriaCountNumericUpDown.Location = new System.Drawing.Point(201, 3);
            this.CriteriaCountNumericUpDown.Name = "CriteriaCountNumericUpDown";
            this.CriteriaCountNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.CriteriaCountNumericUpDown.TabIndex = 20;
            this.CriteriaCountNumericUpDown.ValueChanged += new System.EventHandler(this.CriteriaCountNumericUpDown_ValueChanged);
            // 
            // ObjectCountLabel
            // 
            this.ObjectCountLabel.AutoSize = true;
            this.ObjectCountLabel.Location = new System.Drawing.Point(-3, 5);
            this.ObjectCountLabel.Name = "ObjectCountLabel";
            this.ObjectCountLabel.Size = new System.Drawing.Size(71, 13);
            this.ObjectCountLabel.TabIndex = 18;
            this.ObjectCountLabel.Text = "Object count:";
            // 
            // CriteriaCountLabel
            // 
            this.CriteriaCountLabel.AutoSize = true;
            this.CriteriaCountLabel.Location = new System.Drawing.Point(123, 5);
            this.CriteriaCountLabel.Name = "CriteriaCountLabel";
            this.CriteriaCountLabel.Size = new System.Drawing.Size(72, 13);
            this.CriteriaCountLabel.TabIndex = 17;
            this.CriteriaCountLabel.Text = "Criteria count:";
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.Location = new System.Drawing.Point(612, 0);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 16;
            this.CreateButton.Text = "Create table";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DecreasingCriteriaTableGridControl
            // 
            this.DecreasingCriteriaTableGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecreasingCriteriaTableGridControl.Location = new System.Drawing.Point(3, 16);
            this.DecreasingCriteriaTableGridControl.Name = "DecreasingCriteriaTableGridControl";
            this.DecreasingCriteriaTableGridControl.Size = new System.Drawing.Size(681, 51);
            this.DecreasingCriteriaTableGridControl.TabIndex = 24;
            // 
            // DecreasingCriteriaGroupBox
            // 
            this.DecreasingCriteriaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecreasingCriteriaGroupBox.Controls.Add(this.DecreasingCriteriaTableGridControl);
            this.DecreasingCriteriaGroupBox.Location = new System.Drawing.Point(0, 368);
            this.DecreasingCriteriaGroupBox.Name = "DecreasingCriteriaGroupBox";
            this.DecreasingCriteriaGroupBox.Size = new System.Drawing.Size(687, 70);
            this.DecreasingCriteriaGroupBox.TabIndex = 26;
            this.DecreasingCriteriaGroupBox.TabStop = false;
            this.DecreasingCriteriaGroupBox.Text = "Decreasing criteria";
            // 
            // TableGroupBox
            // 
            this.TableGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableGroupBox.Controls.Add(this.ScoringTableGridControl);
            this.TableGroupBox.Location = new System.Drawing.Point(0, 29);
            this.TableGroupBox.Name = "TableGroupBox";
            this.TableGroupBox.Size = new System.Drawing.Size(687, 333);
            this.TableGroupBox.TabIndex = 0;
            this.TableGroupBox.TabStop = false;
            this.TableGroupBox.Text = "Table";
            // 
            // WithWeightsCheckBox
            // 
            this.WithWeightsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WithWeightsCheckBox.AutoSize = true;
            this.WithWeightsCheckBox.Location = new System.Drawing.Point(0, 444);
            this.WithWeightsCheckBox.Name = "WithWeightsCheckBox";
            this.WithWeightsCheckBox.Size = new System.Drawing.Size(87, 17);
            this.WithWeightsCheckBox.TabIndex = 27;
            this.WithWeightsCheckBox.Text = "With weights";
            this.WithWeightsCheckBox.UseVisualStyleBackColor = true;
            this.WithWeightsCheckBox.CheckedChanged += new System.EventHandler(this.WithWeightsCheckBox_CheckedChanged);
            // 
            // ObjectCriteriaTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeightTableGridControl);
            this.Controls.Add(this.WithWeightsCheckBox);
            this.Controls.Add(this.TableGroupBox);
            this.Controls.Add(this.DecreasingCriteriaGroupBox);
            this.Controls.Add(this.ObjectCountNumericUpDown);
            this.Controls.Add(this.CriteriaCountNumericUpDown);
            this.Controls.Add(this.ObjectCountLabel);
            this.Controls.Add(this.CriteriaCountLabel);
            this.Controls.Add(this.CreateButton);
            this.Name = "ObjectCriteriaTableControl";
            this.Size = new System.Drawing.Size(687, 518);
            ((System.ComponentModel.ISupportInitialize)(this.ObjectCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaCountNumericUpDown)).EndInit();
            this.DecreasingCriteriaGroupBox.ResumeLayout(false);
            this.TableGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleTableGridControl WeightTableGridControl;
        private ScoringTableGridControl ScoringTableGridControl;
        private System.Windows.Forms.NumericUpDown ObjectCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown CriteriaCountNumericUpDown;
        private System.Windows.Forms.Label ObjectCountLabel;
        private System.Windows.Forms.Label CriteriaCountLabel;
        private System.Windows.Forms.Button CreateButton;
        private BoolTableGridControl DecreasingCriteriaTableGridControl;
        private System.Windows.Forms.GroupBox DecreasingCriteriaGroupBox;
        private System.Windows.Forms.GroupBox TableGroupBox;
        private System.Windows.Forms.CheckBox WithWeightsCheckBox;
    }
}
