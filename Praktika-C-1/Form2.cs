using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Artur Shbaunov RDIR61
 *  Kujundada vorm, millel saab sisestada mingi sündmuse kuupäeva ja algusaja. Kontrollida, et sisestatud aeg on tulevikus.
 *  Pärast aja sisestamist seda enam muuta ei saa. Kuvada jooksvalt sündmuseni jäänud aega päevades, tundides, 
 *  minutites ja sekundites. Uuendada kuvatavat aega kord sekundis.
 * 
 */

namespace Praktika_C_1
{
    public partial class W : Form
    {
        public W()
        {
            InitializeComponent();
        }

        static Event ev = new Event();
        static DateTime dt;
        static string timeoff;

        private void firsttask_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as Form1).first.Enabled = true;
        }

        private void W_Load(object sender, EventArgs e)
        {
            timer1.Start();
            clock.Text = DateTime.Now.ToLongTimeString();
            datelabel.Text = DateTime.Now.ToLongDateString();
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            clock.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            UpdateTime();
        }

        

        private void UpdateTime()
        {
            //dataGridView1.Rows[]
            
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if(Convert.ToString(row.Cells["endtime"].Value) != string.Empty)
                {
                    dt = Convert.ToDateTime(row.Cells[0].Value.ToString()).Date + Convert.ToDateTime(row.Cells[1].Value.ToString()).TimeOfDay;
                    TimeSpan ts = dt - DateTime.Now;
                    timeoff = string.Format("{0} day, {1} hour, {2} minute", ts.Days, ts.Hours, ts.Minutes);
                    row.Cells[3].Value = timeoff;

                    
                        if (ts.Days == 0 && ts.Hours == 0 && ts.Minutes == 0)
                        {
                        dataGridView1.Rows.RemoveAt(row.Index);
                        }
                    

                    
                }
                dataGridView1.Refresh();
                    //More code here
                }
            
            
        }

        private void addtimer_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(descrp.Text))
            {
                MessageBox.Show("Enter Name Event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dt = dateTimePicker1.Value.Date + dateTimePicker2.Value.TimeOfDay; 
                TimeSpan ts = dt - DateTime.Now;
                timeoff = string.Format("{0} day, {1} hour, {2} minute", ts.Days, ts.Hours, ts.Minutes);
                ev = new Event(descrp.Text, dt, timeoff);

                if (ev.dateevent.Date == DateTime.Now.Date)
                {
                    if (ev.dateevent.Hour > DateTime.Now.Hour )
                    {

                        dataGridView1.Rows.Add(ev.dateevent.ToString("dd.MM.yyyy"), ev.dateevent.ToString("HH:mm"), ev.nameevent, ev.timeoff);
                    }
                    else
                    {
                        MessageBox.Show("Check Time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (ev.dateevent.Date >= DateTime.Now.Date)
                {

                    dataGridView1.Rows.Add(ev.dateevent.ToString("dd.MM.yyyy"), ev.dateevent.ToString("hh:mm"), ev.nameevent, ev.timeoff);
                }
                else
                {
                    MessageBox.Show("Check Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } 
        }
    }
}
