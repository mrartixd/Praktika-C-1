namespace Praktika_C_1
{
    partial class W
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // logs
            // 
            this.logs.FormattingEnabled = true;
            this.logs.ItemHeight = 16;
            this.logs.Location = new System.Drawing.Point(48, 272);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(522, 324);
            this.logs.TabIndex = 0;
            // 
            // W
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 645);
            this.Controls.Add(this.logs);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(648, 692);
            this.MinimumSize = new System.Drawing.Size(648, 692);
            this.Name = "W";
            this.Text = "1 Ulesanne";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.firsttask_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox logs;
    }
}