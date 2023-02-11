namespace DecisionUnderUncertaintyApp.Views.Controls
{
    partial class OptionsEnvironmentsTableControl
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
            this.EnviromentCountLabel = new System.Windows.Forms.Label();
            this.OptionCountLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.EnvironmentCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OptionCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TableGroupBox = new System.Windows.Forms.GroupBox();
            this.DoubleMatrixControl = new DecisionUnderUncertaintyApp.Views.Controls.DoubleMatrixControl();
            this.IsLossTableCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnvironmentCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionCountNumericUpDown)).BeginInit();
            this.TableGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnviromentCountLabel
            // 
            this.EnviromentCountLabel.AutoSize = true;
            this.EnviromentCountLabel.Location = new System.Drawing.Point(123, 5);
            this.EnviromentCountLabel.Name = "EnviromentCountLabel";
            this.EnviromentCountLabel.Size = new System.Drawing.Size(93, 13);
            this.EnviromentCountLabel.TabIndex = 9;
            this.EnviromentCountLabel.Text = "Enviroment count:";
            // 
            // OptionCountLabel
            // 
            this.OptionCountLabel.AutoSize = true;
            this.OptionCountLabel.Location = new System.Drawing.Point(-3, 5);
            this.OptionCountLabel.Name = "OptionCountLabel";
            this.OptionCountLabel.Size = new System.Drawing.Size(71, 13);
            this.OptionCountLabel.TabIndex = 8;
            this.OptionCountLabel.Text = "Option count:";
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.Location = new System.Drawing.Point(630, 0);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create table";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // EnvironmentCountNumericUpDown
            // 
            this.EnvironmentCountNumericUpDown.Location = new System.Drawing.Point(222, 3);
            this.EnvironmentCountNumericUpDown.Name = "EnvironmentCountNumericUpDown";
            this.EnvironmentCountNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.EnvironmentCountNumericUpDown.TabIndex = 6;
            this.EnvironmentCountNumericUpDown.ValueChanged += new System.EventHandler(this.EnvironmentCountNumericUpDown_ValueChanged);
            // 
            // OptionCountNumericUpDown
            // 
            this.OptionCountNumericUpDown.Location = new System.Drawing.Point(74, 3);
            this.OptionCountNumericUpDown.Name = "OptionCountNumericUpDown";
            this.OptionCountNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.OptionCountNumericUpDown.TabIndex = 5;
            this.OptionCountNumericUpDown.ValueChanged += new System.EventHandler(this.OptionCountNumericUpDown_ValueChanged);
            // 
            // TableGroupBox
            // 
            this.TableGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableGroupBox.Controls.Add(this.DoubleMatrixControl);
            this.TableGroupBox.Location = new System.Drawing.Point(0, 29);
            this.TableGroupBox.Name = "TableGroupBox";
            this.TableGroupBox.Size = new System.Drawing.Size(705, 386);
            this.TableGroupBox.TabIndex = 10;
            this.TableGroupBox.TabStop = false;
            this.TableGroupBox.Text = "Table";
            // 
            // DoubleMatrixControl
            // 
            this.DoubleMatrixControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoubleMatrixControl.Location = new System.Drawing.Point(3, 16);
            this.DoubleMatrixControl.Name = "DoubleMatrixControl";
            this.DoubleMatrixControl.Size = new System.Drawing.Size(699, 367);
            this.DoubleMatrixControl.TabIndex = 0;
            this.DoubleMatrixControl.MatrixChanged += new System.EventHandler(this.DoubleMatrixControl_MatrixChanged);
            // 
            // IsLossTableCheckBox
            // 
            this.IsLossTableCheckBox.AutoSize = true;
            this.IsLossTableCheckBox.Location = new System.Drawing.Point(271, 4);
            this.IsLossTableCheckBox.Name = "IsLossTableCheckBox";
            this.IsLossTableCheckBox.Size = new System.Drawing.Size(81, 17);
            this.IsLossTableCheckBox.TabIndex = 11;
            this.IsLossTableCheckBox.Text = "Is loss table";
            this.IsLossTableCheckBox.UseVisualStyleBackColor = true;
            this.IsLossTableCheckBox.CheckedChanged += new System.EventHandler(this.IsLossTableCheckBox_CheckedChanged);
            // 
            // OptionsEnvironmentsTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IsLossTableCheckBox);
            this.Controls.Add(this.TableGroupBox);
            this.Controls.Add(this.EnviromentCountLabel);
            this.Controls.Add(this.OptionCountLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.EnvironmentCountNumericUpDown);
            this.Controls.Add(this.OptionCountNumericUpDown);
            this.Name = "OptionsEnvironmentsTableControl";
            this.Size = new System.Drawing.Size(705, 415);
            ((System.ComponentModel.ISupportInitialize)(this.EnvironmentCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionCountNumericUpDown)).EndInit();
            this.TableGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnviromentCountLabel;
        private System.Windows.Forms.Label OptionCountLabel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.NumericUpDown EnvironmentCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown OptionCountNumericUpDown;
        private System.Windows.Forms.GroupBox TableGroupBox;
        private DoubleMatrixControl DoubleMatrixControl;
        private System.Windows.Forms.CheckBox IsLossTableCheckBox;
    }
}
