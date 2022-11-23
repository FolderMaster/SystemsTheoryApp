namespace GeneralizationApp.Views.Controls
{
    partial class ObjectCriteriaRollupTableControl
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
            this.TableWeightsGridControl = new GeneralizationApp.Views.Controls.TableWeightsGridControl();
            this.ScoringTableGridControl = new GeneralizationApp.Views.Controls.ScoringTableGridControl();
            this.ObjectCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CriteriaCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ObjectCountLabel = new System.Windows.Forms.Label();
            this.CriteriaCountLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TableWeightsGridControl
            // 
            this.TableWeightsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableWeightsGridControl.Location = new System.Drawing.Point(0, 469);
            this.TableWeightsGridControl.Name = "TableWeightsGridControl";
            this.TableWeightsGridControl.Size = new System.Drawing.Size(687, 49);
            this.TableWeightsGridControl.TabIndex = 23;
            // 
            // ScoringTableGridControl
            // 
            this.ScoringTableGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoringTableGridControl.Location = new System.Drawing.Point(0, 34);
            this.ScoringTableGridControl.Name = "ScoringTableGridControl";
            this.ScoringTableGridControl.Size = new System.Drawing.Size(687, 429);
            this.ScoringTableGridControl.TabIndex = 22;
            // 
            // ObjectCountNumericUpDown
            // 
            this.ObjectCountNumericUpDown.Location = new System.Drawing.Point(72, 3);
            this.ObjectCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ObjectCountNumericUpDown.Name = "ObjectCountNumericUpDown";
            this.ObjectCountNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.ObjectCountNumericUpDown.TabIndex = 21;
            this.ObjectCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ObjectCountNumericUpDown.ValueChanged += new System.EventHandler(this.ObjectCountNumericUpDown_ValueChanged);
            // 
            // CriteriaCountNumericUpDown
            // 
            this.CriteriaCountNumericUpDown.Location = new System.Drawing.Point(197, 3);
            this.CriteriaCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CriteriaCountNumericUpDown.Name = "CriteriaCountNumericUpDown";
            this.CriteriaCountNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.CriteriaCountNumericUpDown.TabIndex = 20;
            this.CriteriaCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CriteriaCountNumericUpDown.ValueChanged += new System.EventHandler(this.CriteriaCountNumericUpDown_ValueChanged);
            // 
            // ObjectCountLabel
            // 
            this.ObjectCountLabel.AutoSize = true;
            this.ObjectCountLabel.Location = new System.Drawing.Point(-3, 5);
            this.ObjectCountLabel.Name = "ObjectCountLabel";
            this.ObjectCountLabel.Size = new System.Drawing.Size(69, 13);
            this.ObjectCountLabel.TabIndex = 18;
            this.ObjectCountLabel.Text = "ObjectCount:";
            // 
            // CriteriaCountLabel
            // 
            this.CriteriaCountLabel.AutoSize = true;
            this.CriteriaCountLabel.Location = new System.Drawing.Point(121, 5);
            this.CriteriaCountLabel.Name = "CriteriaCountLabel";
            this.CriteriaCountLabel.Size = new System.Drawing.Size(70, 13);
            this.CriteriaCountLabel.TabIndex = 17;
            this.CriteriaCountLabel.Text = "CriteriaCount:";
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.Location = new System.Drawing.Point(612, 0);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 16;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ObjectCriteriaRollupTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableWeightsGridControl);
            this.Controls.Add(this.ScoringTableGridControl);
            this.Controls.Add(this.ObjectCountNumericUpDown);
            this.Controls.Add(this.CriteriaCountNumericUpDown);
            this.Controls.Add(this.ObjectCountLabel);
            this.Controls.Add(this.CriteriaCountLabel);
            this.Controls.Add(this.CreateButton);
            this.Name = "ObjectCriteriaRollupTableControl";
            this.Size = new System.Drawing.Size(687, 518);
            ((System.ComponentModel.ISupportInitialize)(this.ObjectCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableWeightsGridControl TableWeightsGridControl;
        private ScoringTableGridControl ScoringTableGridControl;
        private System.Windows.Forms.NumericUpDown ObjectCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown CriteriaCountNumericUpDown;
        private System.Windows.Forms.Label ObjectCountLabel;
        private System.Windows.Forms.Label CriteriaCountLabel;
        private System.Windows.Forms.Button CreateButton;
    }
}
