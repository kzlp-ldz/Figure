
namespace Figure
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCirkle = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCirkle
            // 
            this.btnCirkle.Location = new System.Drawing.Point(298, 38);
            this.btnCirkle.Name = "btnCirkle";
            this.btnCirkle.Size = new System.Drawing.Size(135, 56);
            this.btnCirkle.TabIndex = 0;
            this.btnCirkle.Text = "Нарисовать круг";
            this.btnCirkle.UseVisualStyleBackColor = true;
            this.btnCirkle.Click += new System.EventHandler(this.btnCirkle_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(138, 55);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 1;
            this.txtRadius.TextChanged += new System.EventHandler(this.txtRadius_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Радиус";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.btnCirkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCirkle;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadius;
    }
}

