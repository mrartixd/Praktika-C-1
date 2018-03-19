namespace Praktika_C_1
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
            this.first = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.Button();
            this.third = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(156, 59);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(156, 68);
            this.first.TabIndex = 0;
            this.first.Text = "1 Ulesanne";
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(156, 143);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(156, 68);
            this.second.TabIndex = 1;
            this.second.Text = "2 Ulesanne";
            this.second.UseVisualStyleBackColor = true;
            this.second.Click += new System.EventHandler(this.secont_Click);
            // 
            // third
            // 
            this.third.Location = new System.Drawing.Point(156, 229);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(156, 68);
            this.third.TabIndex = 2;
            this.third.Text = "3 Ulesanne";
            this.third.UseVisualStyleBackColor = true;
            this.third.Click += new System.EventHandler(this.third_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 325);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(487, 372);
            this.MinimumSize = new System.Drawing.Size(487, 372);
            this.Name = "Form1";
            this.Text = "Start Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button first;
        public System.Windows.Forms.Button second;
        public System.Windows.Forms.Button third;
    }
}

