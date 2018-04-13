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
            this.components = new System.ComponentModel.Container();
            this.addtimer = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.descrp = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datecl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timecl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrpcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addtimer
            // 
            this.addtimer.Location = new System.Drawing.Point(260, 223);
            this.addtimer.Name = "addtimer";
            this.addtimer.Size = new System.Drawing.Size(90, 37);
            this.addtimer.TabIndex = 1;
            this.addtimer.Text = "ADD";
            this.addtimer.UseVisualStyleBackColor = true;
            this.addtimer.Click += new System.EventHandler(this.addtimer_Click);
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clock.Location = new System.Drawing.Point(255, 9);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(52, 25);
            this.clock.TabIndex = 2;
            this.clock.Text = "time";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datelabel.Location = new System.Drawing.Point(220, 34);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(54, 25);
            this.datelabel.TabIndex = 3;
            this.datelabel.Text = "date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2018, 4, 13, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(449, 114);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(109, 22);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(2018, 3, 20, 0, 0, 0, 0);
            // 
            // descrp
            // 
            this.descrp.Location = new System.Drawing.Point(166, 170);
            this.descrp.Name = "descrp";
            this.descrp.Size = new System.Drawing.Size(292, 22);
            this.descrp.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datecl,
            this.timecl,
            this.descrpcl,
            this.endtime});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 339);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date event:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time event:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name event:";
            // 
            // datecl
            // 
            this.datecl.HeaderText = "Date";
            this.datecl.Name = "datecl";
            this.datecl.Width = 80;
            // 
            // timecl
            // 
            this.timecl.HeaderText = "Time";
            this.timecl.Name = "timecl";
            this.timecl.Width = 80;
            // 
            // descrpcl
            // 
            this.descrpcl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descrpcl.HeaderText = "Description";
            this.descrpcl.MinimumWidth = 120;
            this.descrpcl.Name = "descrpcl";
            this.descrpcl.Width = 120;
            // 
            // endtime
            // 
            this.endtime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.endtime.HeaderText = "End";
            this.endtime.MinimumWidth = 50;
            this.endtime.Name = "endtime";
            this.endtime.Width = 62;
            // 
            // W
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 645);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.descrp);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.addtimer);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(648, 692);
            this.MinimumSize = new System.Drawing.Size(648, 692);
            this.Name = "W";
            this.Text = "1 Ulesanne Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.firsttask_FormClosing);
            this.Load += new System.EventHandler(this.W_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addtimer;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox descrp;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecl;
        private System.Windows.Forms.DataGridViewTextBoxColumn timecl;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrpcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtime;
    }
}