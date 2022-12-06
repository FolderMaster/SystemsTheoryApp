namespace SystemAnalysisMethodApp.Views.Tabs
{
    partial class PairComparisonCalculationTab
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
            this.VectorGridView = new System.Windows.Forms.DataGridView();
            this.LmaxGridView = new System.Windows.Forms.DataGridView();
            this.VectorsGroupBox = new System.Windows.Forms.GroupBox();
            this.LmaxGroupBox = new System.Windows.Forms.GroupBox();
            this.ConsistencyRelationGroupBox = new System.Windows.Forms.GroupBox();
            this.ConsistencyRelationTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.VectorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LmaxGridView)).BeginInit();
            this.VectorsGroupBox.SuspendLayout();
            this.LmaxGroupBox.SuspendLayout();
            this.ConsistencyRelationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // VectorGridView
            // 
            this.VectorGridView.AllowUserToAddRows = false;
            this.VectorGridView.AllowUserToDeleteRows = false;
            this.VectorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VectorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VectorGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VectorGridView.Location = new System.Drawing.Point(3, 16);
            this.VectorGridView.Name = "VectorGridView";
            this.VectorGridView.ReadOnly = true;
            this.VectorGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VectorGridView.Size = new System.Drawing.Size(415, 205);
            this.VectorGridView.TabIndex = 0;
            this.VectorGridView.SizeChanged += new System.EventHandler(this.PairComparisonMatrixGridView_SizeChanged);
            // 
            // LmaxGridView
            // 
            this.LmaxGridView.AllowUserToAddRows = false;
            this.LmaxGridView.AllowUserToDeleteRows = false;
            this.LmaxGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LmaxGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LmaxGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LmaxGridView.Location = new System.Drawing.Point(3, 16);
            this.LmaxGridView.Name = "LmaxGridView";
            this.LmaxGridView.ReadOnly = true;
            this.LmaxGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LmaxGridView.Size = new System.Drawing.Size(415, 73);
            this.LmaxGridView.TabIndex = 1;
            // 
            // VectorsGroupBox
            // 
            this.VectorsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VectorsGroupBox.Controls.Add(this.VectorGridView);
            this.VectorsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.VectorsGroupBox.Name = "VectorsGroupBox";
            this.VectorsGroupBox.Size = new System.Drawing.Size(421, 224);
            this.VectorsGroupBox.TabIndex = 2;
            this.VectorsGroupBox.TabStop = false;
            this.VectorsGroupBox.Text = "Vectors";
            // 
            // LmaxGroupBox
            // 
            this.LmaxGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LmaxGroupBox.Controls.Add(this.LmaxGridView);
            this.LmaxGroupBox.Location = new System.Drawing.Point(0, 230);
            this.LmaxGroupBox.Name = "LmaxGroupBox";
            this.LmaxGroupBox.Size = new System.Drawing.Size(421, 92);
            this.LmaxGroupBox.TabIndex = 3;
            this.LmaxGroupBox.TabStop = false;
            this.LmaxGroupBox.Text = "Lmax";
            // 
            // ConsistencyRelationGroupBox
            // 
            this.ConsistencyRelationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsistencyRelationGroupBox.Controls.Add(this.ConsistencyRelationTextBox);
            this.ConsistencyRelationGroupBox.Location = new System.Drawing.Point(0, 328);
            this.ConsistencyRelationGroupBox.Name = "ConsistencyRelationGroupBox";
            this.ConsistencyRelationGroupBox.Size = new System.Drawing.Size(421, 45);
            this.ConsistencyRelationGroupBox.TabIndex = 4;
            this.ConsistencyRelationGroupBox.TabStop = false;
            this.ConsistencyRelationGroupBox.Text = "Consistency relation";
            // 
            // ConsistencyRelationTextBox
            // 
            this.ConsistencyRelationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsistencyRelationTextBox.Location = new System.Drawing.Point(3, 16);
            this.ConsistencyRelationTextBox.Name = "ConsistencyRelationTextBox";
            this.ConsistencyRelationTextBox.ReadOnly = true;
            this.ConsistencyRelationTextBox.Size = new System.Drawing.Size(415, 20);
            this.ConsistencyRelationTextBox.TabIndex = 0;
            // 
            // PairComparisonCalculationTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConsistencyRelationGroupBox);
            this.Controls.Add(this.LmaxGroupBox);
            this.Controls.Add(this.VectorsGroupBox);
            this.Name = "PairComparisonCalculationTab";
            this.Size = new System.Drawing.Size(421, 373);
            ((System.ComponentModel.ISupportInitialize)(this.VectorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LmaxGridView)).EndInit();
            this.VectorsGroupBox.ResumeLayout(false);
            this.LmaxGroupBox.ResumeLayout(false);
            this.ConsistencyRelationGroupBox.ResumeLayout(false);
            this.ConsistencyRelationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VectorGridView;
        private System.Windows.Forms.DataGridView LmaxGridView;
        private System.Windows.Forms.GroupBox VectorsGroupBox;
        private System.Windows.Forms.GroupBox LmaxGroupBox;
        private System.Windows.Forms.GroupBox ConsistencyRelationGroupBox;
        private System.Windows.Forms.TextBox ConsistencyRelationTextBox;
    }
}
