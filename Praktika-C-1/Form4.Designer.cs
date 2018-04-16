namespace Praktika_C_1
{
    partial class thirdtask
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
            this.components = new System.ComponentModel.Container();
            this.onegasimg = new System.Windows.Forms.PictureBox();
            this.twogasimg = new System.Windows.Forms.PictureBox();
            this.thrigasimg = new System.Windows.Forms.PictureBox();
            this.fourgasimg = new System.Windows.Forms.PictureBox();
            this.onegastext = new System.Windows.Forms.TextBox();
            this.twogastext = new System.Windows.Forms.TextBox();
            this.thirdgastext = new System.Windows.Forms.TextBox();
            this.fourgastext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerkassa = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Timer(this.components);
            this.pricetext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.onegasimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twogasimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thrigasimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourgasimg)).BeginInit();
            this.SuspendLayout();
            // 
            // onegasimg
            // 
            this.onegasimg.Image = global::Praktika_C_1.Properties.Resources.fuel;
            this.onegasimg.Location = new System.Drawing.Point(101, 85);
            this.onegasimg.Name = "onegasimg";
            this.onegasimg.Size = new System.Drawing.Size(245, 164);
            this.onegasimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onegasimg.TabIndex = 0;
            this.onegasimg.TabStop = false;
            // 
            // twogasimg
            // 
            this.twogasimg.Image = global::Praktika_C_1.Properties.Resources.fuel;
            this.twogasimg.Location = new System.Drawing.Point(540, 85);
            this.twogasimg.Name = "twogasimg";
            this.twogasimg.Size = new System.Drawing.Size(245, 164);
            this.twogasimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twogasimg.TabIndex = 1;
            this.twogasimg.TabStop = false;
            // 
            // thrigasimg
            // 
            this.thrigasimg.Image = global::Praktika_C_1.Properties.Resources.fuel;
            this.thrigasimg.Location = new System.Drawing.Point(101, 443);
            this.thrigasimg.Name = "thrigasimg";
            this.thrigasimg.Size = new System.Drawing.Size(245, 164);
            this.thrigasimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thrigasimg.TabIndex = 2;
            this.thrigasimg.TabStop = false;
            // 
            // fourgasimg
            // 
            this.fourgasimg.Image = global::Praktika_C_1.Properties.Resources.fuel;
            this.fourgasimg.Location = new System.Drawing.Point(540, 443);
            this.fourgasimg.Name = "fourgasimg";
            this.fourgasimg.Size = new System.Drawing.Size(245, 164);
            this.fourgasimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fourgasimg.TabIndex = 3;
            this.fourgasimg.TabStop = false;
            // 
            // onegastext
            // 
            this.onegastext.Location = new System.Drawing.Point(168, 271);
            this.onegastext.Name = "onegastext";
            this.onegastext.Size = new System.Drawing.Size(100, 22);
            this.onegastext.TabIndex = 4;
            this.onegastext.Text = "0";
            this.onegastext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onegastext_KeyPress);
            // 
            // twogastext
            // 
            this.twogastext.Location = new System.Drawing.Point(601, 271);
            this.twogastext.Name = "twogastext";
            this.twogastext.Size = new System.Drawing.Size(100, 22);
            this.twogastext.TabIndex = 5;
            this.twogastext.Text = "0";
            this.twogastext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.twogastext_KeyPress);
            // 
            // thirdgastext
            // 
            this.thirdgastext.Location = new System.Drawing.Point(168, 629);
            this.thirdgastext.Name = "thirdgastext";
            this.thirdgastext.Size = new System.Drawing.Size(100, 22);
            this.thirdgastext.TabIndex = 6;
            this.thirdgastext.Text = "0";
            this.thirdgastext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thirdgastext_KeyPress);
            // 
            // fourgastext
            // 
            this.fourgastext.Location = new System.Drawing.Point(601, 629);
            this.fourgastext.Name = "fourgastext";
            this.fourgastext.Size = new System.Drawing.Size(100, 22);
            this.fourgastext.TabIndex = 7;
            this.fourgastext.Text = "0";
            this.fourgastext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fourgastext_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Liters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Liters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 632);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Liters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 632);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Liters";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Fuel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Fuel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 657);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Fuel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(615, 657);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Fuel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(101, 56);
            this.progressBar1.MarqueeAnimationSpeed = 10000;
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(245, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(540, 56);
            this.progressBar2.MarqueeAnimationSpeed = 10000;
            this.progressBar2.Maximum = 10000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(245, 23);
            this.progressBar2.TabIndex = 17;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(101, 414);
            this.progressBar3.MarqueeAnimationSpeed = 10000;
            this.progressBar3.Maximum = 10000;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(245, 23);
            this.progressBar3.TabIndex = 18;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(540, 414);
            this.progressBar4.MarqueeAnimationSpeed = 10000;
            this.progressBar4.Maximum = 10000;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(245, 23);
            this.progressBar4.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerkassa
            // 
            this.timerkassa.AutoSize = true;
            this.timerkassa.Location = new System.Drawing.Point(925, 414);
            this.timerkassa.Name = "timerkassa";
            this.timerkassa.Size = new System.Drawing.Size(24, 17);
            this.timerkassa.TabIndex = 20;
            this.timerkassa.Text = "60";
            // 
            // sec
            // 
            this.sec.Interval = 1000;
            this.sec.Tick += new System.EventHandler(this.sec_Tick);
            // 
            // pricetext
            // 
            this.pricetext.AutoSize = true;
            this.pricetext.Location = new System.Drawing.Point(928, 443);
            this.pricetext.Name = "pricetext";
            this.pricetext.Size = new System.Drawing.Size(46, 17);
            this.pricetext.TabIndex = 21;
            this.pricetext.Text = "label5";
            // 
            // thirdtask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 802);
            this.Controls.Add(this.pricetext);
            this.Controls.Add(this.timerkassa);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fourgastext);
            this.Controls.Add(this.thirdgastext);
            this.Controls.Add(this.twogastext);
            this.Controls.Add(this.onegastext);
            this.Controls.Add(this.fourgasimg);
            this.Controls.Add(this.thrigasimg);
            this.Controls.Add(this.twogasimg);
            this.Controls.Add(this.onegasimg);
            this.MaximumSize = new System.Drawing.Size(1323, 849);
            this.MinimumSize = new System.Drawing.Size(1323, 849);
            this.Name = "thirdtask";
            this.Text = "3 Ulesanne";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.thirdtask_FormClosing);
            this.Load += new System.EventHandler(this.thirdtask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.onegasimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twogasimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thrigasimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourgasimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox onegasimg;
        private System.Windows.Forms.PictureBox twogasimg;
        private System.Windows.Forms.PictureBox thrigasimg;
        private System.Windows.Forms.PictureBox fourgasimg;
        private System.Windows.Forms.TextBox onegastext;
        private System.Windows.Forms.TextBox twogastext;
        private System.Windows.Forms.TextBox thirdgastext;
        private System.Windows.Forms.TextBox fourgastext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerkassa;
        private System.Windows.Forms.Timer sec;
        private System.Windows.Forms.Label pricetext;
    }
}