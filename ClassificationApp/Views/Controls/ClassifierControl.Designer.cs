namespace ClassificationApp.Views.Controls
{
    partial class ClassifierControl
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
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.ClassifyButton = new System.Windows.Forms.Button();
            this.ClassifierLabel = new System.Windows.Forms.Label();
            this.NeighborsCountLabel = new System.Windows.Forms.Label();
            this.NeighborsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NeighborsCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(138, 2);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComboBox.TabIndex = 3;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // ClassifyButton
            // 
            this.ClassifyButton.Location = new System.Drawing.Point(0, 0);
            this.ClassifyButton.Name = "ClassifyButton";
            this.ClassifyButton.Size = new System.Drawing.Size(75, 23);
            this.ClassifyButton.TabIndex = 1;
            this.ClassifyButton.Text = "Classify";
            this.ClassifyButton.UseVisualStyleBackColor = true;
            this.ClassifyButton.Click += new System.EventHandler(this.ClassifyButton_Click);
            // 
            // ClassifierLabel
            // 
            this.ClassifierLabel.AutoSize = true;
            this.ClassifierLabel.Location = new System.Drawing.Point(81, 5);
            this.ClassifierLabel.Name = "ClassifierLabel";
            this.ClassifierLabel.Size = new System.Drawing.Size(51, 13);
            this.ClassifierLabel.TabIndex = 2;
            this.ClassifierLabel.Text = "Classifier:";
            // 
            // NeighborsCountLabel
            // 
            this.NeighborsCountLabel.AutoSize = true;
            this.NeighborsCountLabel.Location = new System.Drawing.Point(265, 5);
            this.NeighborsCountLabel.Name = "NeighborsCountLabel";
            this.NeighborsCountLabel.Size = new System.Drawing.Size(88, 13);
            this.NeighborsCountLabel.TabIndex = 4;
            this.NeighborsCountLabel.Text = "Neighbors count:";
            this.NeighborsCountLabel.Visible = false;
            // 
            // NeighborsCountNumericUpDown
            // 
            this.NeighborsCountNumericUpDown.Location = new System.Drawing.Point(359, 3);
            this.NeighborsCountNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NeighborsCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NeighborsCountNumericUpDown.Name = "NeighborsCountNumericUpDown";
            this.NeighborsCountNumericUpDown.Size = new System.Drawing.Size(33, 20);
            this.NeighborsCountNumericUpDown.TabIndex = 5;
            this.NeighborsCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NeighborsCountNumericUpDown.Visible = false;
            // 
            // ClassifierControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NeighborsCountNumericUpDown);
            this.Controls.Add(this.NeighborsCountLabel);
            this.Controls.Add(this.ClassifierLabel);
            this.Controls.Add(this.ClassifyButton);
            this.Controls.Add(this.ComboBox);
            this.Name = "ClassifierControl";
            this.Size = new System.Drawing.Size(447, 25);
            ((System.ComponentModel.ISupportInitialize)(this.NeighborsCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button ClassifyButton;
        private System.Windows.Forms.Label ClassifierLabel;
        private System.Windows.Forms.Label NeighborsCountLabel;
        private System.Windows.Forms.NumericUpDown NeighborsCountNumericUpDown;
    }
}
