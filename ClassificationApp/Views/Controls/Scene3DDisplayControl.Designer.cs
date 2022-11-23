namespace ClassificationApp.Views.Controls
{
    partial class Scene3DDisplayControl
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
            this.SuspendLayout();
            // 
            // Scene3DDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Scene3DDisplayControl";
            this.Size = new System.Drawing.Size(945, 590);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Schedule3DControl_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Scene3DDisplayControl_KeyPress);
            this.Resize += new System.EventHandler(this.Schedule3DControl_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
