using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_C_1
{

    public partial class secondtask : Form
    {
        static Device lamp = new Device();
        static Device radiator = new Device();
        static Device heater = new Device();
        static Device coffe = new Device();
        static Device refrigerator = new Device();
        static Bitmap switchon = Properties.Resources.switch__1_;
        static Bitmap switchoff = Properties.Resources._switch;
        static double currentnum = 0;
        static int hh = DateTime.Now.Hour;
        static int mm = 0;
        static String time;
        public secondtask()
        {
            InitializeComponent();

        }

        private void secondtask_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as Form1).second.Enabled = true;
        }

        private void InvisibleInfo()
        {
            named.Visible = false;
            energyd.Visible = false;
            timerd.Visible = false;
            actived.Visible = false;
        }
        private void VisibleInfo()
        {
            named.Visible = true;
            energyd.Visible = true;
            timerd.Visible = true;
            actived.Visible = true;
        }

        private void secondtask_Load(object sender, EventArgs e)
        {

            //timer

            

            timer1.Tick += new EventHandler(this.timer1_Tick);
            timer1.Start();
            minute.Tick += new EventHandler(minute_Tick);
            minute.Start();


            //---

            current.Text = Convert.ToString(currentnum);
            InvisibleInfo();
            lamp = new Device("Lamps", 20, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 30, 00), false);
            radiator = new Device("Radiator", 2000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 00, 00), false);
            heater = new Device("Water Heater", 8000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 00, 00), false);
            coffe = new Device("Coffe machine", 400, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 20, 00), false);
            refrigerator = new Device("Refrigerator", 110, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00), false);
           
            
        }

        private void AutoON()
        {
            DateTime clock = Convert.ToDateTime(time);
            if(coffetimer.Checked == true && clock == coffe.timeon && coffe.active == false)
            {
                currentnum = currentnum + coffe.energy;
                coffe.active = true;
                pictureBox2.Image = switchon;
            }
            if(lamptimer.Checked == true && clock == lamp.timeon && lamp.active == false)
            {
                currentnum = currentnum + lamp.energy;
                lamp.active = true;
                pictureBox3.Image = switchon;
            }
            if(refrigeratortimer.Checked == true && clock == refrigerator.timeon && refrigerator.active == false)
            {
                currentnum = currentnum + refrigerator.energy;
                refrigerator.active = true;
                pictureBox5.Image = switchon;
            }
            if(heatertimer.Checked == true && clock == heater.timeon && heater.active == false)
            {
                currentnum = currentnum + heater.energy;
                heater.active = true;
                pictureBox7.Image = switchon;
            }
            if(radiatortimer.Checked == true && clock == radiator.timeon && radiator.active == false)
            {
                currentnum = currentnum + radiator.energy;
                radiator.active = true;
                pictureBox9.Image = switchon;
            }
            ShwoLabelAndLoad();
        }

        private void ShwoLabelAndLoad()
        {
            current.Text = Convert.ToString(currentnum + " kWh");
            loadbar.Value = Convert.ToInt32(currentnum);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (coffe.active == false)
            {
                currentnum = currentnum + coffe.energy;
                coffe.active = true;
                pictureBox2.Image = switchon;
            }
            else
            {
                currentnum = currentnum - coffe.energy;
                coffe.active = false;
                pictureBox2.Image = switchoff;
            }
            ShwoLabelAndLoad();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (lamp.active == false)
            {
                currentnum = currentnum + lamp.energy;
                lamp.active = true;
                pictureBox3.Image = switchon;
            }
            else
            {
                currentnum = currentnum - lamp.energy;
                lamp.active = false;
                pictureBox3.Image = switchoff;
            }
            ShwoLabelAndLoad();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (refrigerator.active == false)
            {
                currentnum = currentnum + refrigerator.energy;
                refrigerator.active = true;
                pictureBox5.Image = switchon;
            }
            else
            {
                currentnum = currentnum - refrigerator.energy;
                refrigerator.active = false;
                pictureBox5.Image = switchoff;
            }
            ShwoLabelAndLoad();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (heater.active == false)
            {
                currentnum = currentnum + heater.energy;
                heater.active =true;
                pictureBox7.Image = switchon;
            }
            else
            {
                currentnum = currentnum - heater.energy;
                heater.active = false;
                pictureBox7.Image = switchoff;
            }
            ShwoLabelAndLoad();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (radiator.active == false)
            {
                currentnum = currentnum + radiator.energy;
                radiator.active = true;
                pictureBox9.Image = switchon;
            }
            else
            {
                currentnum = currentnum - radiator.energy;
                radiator.active = false;
                pictureBox9.Image = switchoff;
            }
            ShwoLabelAndLoad();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            VisibleInfo();
            named.Text = coffe.namedevice;
            energyd.Text = Convert.ToString(coffe.energy / 1000 + " kWh");
            timerd.Text = Convert.ToString(coffe.timeon);

            if (coffe.active == true)
            {
                actived.Text = "active";

            }
            else
            {
                actived.Text = "turnoff";
            }

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            VisibleInfo();
            named.Text = lamp.namedevice;
            energyd.Text = Convert.ToString(lamp.energy / 1000 + " kWh");
            timerd.Text = Convert.ToString(lamp.timeon);

            if (lamp.active == true)
            {
                actived.Text = "active";

            }
            else
            {
                actived.Text = "turnoff";
            }
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            VisibleInfo();
            named.Text = refrigerator.namedevice;
            energyd.Text = Convert.ToString(refrigerator.energy / 1000 + " kWh");
            timerd.Text = Convert.ToString(refrigerator.timeon);

            if (refrigerator.active == true)
            {
                actived.Text = "active";

            }
            else
            {
                actived.Text = "turnoff";
            }
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            VisibleInfo();
            named.Text = heater.namedevice;
            energyd.Text = Convert.ToString(heater.energy / 1000 + " kWh");
            timerd.Text = Convert.ToString(heater.timeon);

            if (heater.active == true)
            {
                actived.Text = "active";
            }
            else
            {
                actived.Text = "turnoff";
            }
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            VisibleInfo();
            named.Text = radiator.namedevice;
            energyd.Text = Convert.ToString(radiator.energy / 1000 + " kWh");
            timerd.Text = Convert.ToString(radiator.timeon);
            if (radiator.active == true)
            {
                actived.Text = "active";
            }
            else
            {
                actived.Text = "turnoff";
            }
        }

        private void secondtask_MouseHover(object sender, EventArgs e)
        {
            InvisibleInfo();
        }

        private void minute_Tick(object sender, EventArgs e)
        {
            mm ++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            coffetimer.Text = coffe.timeon.ToString("HH:mm");
            lamptimer.Text = lamp.timeon.ToString("HH:mm");
            refrigeratortimer.Text = refrigerator.timeon.ToString("HH:mm");
            heatertimer.Text = heater.timeon.ToString("HH:mm");
            radiatortimer.Text = radiator.timeon.ToString("HH:mm");
            time = "";
            if (hh > 23 && mm>59)
            {
                hh = 0;
                mm = 0;
            }
            else if (mm> 59)
            {
                mm = 00;
                hh += 1;
            }
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            label6.Visible = true;
            label6.Text = time;
            AutoON();
        }

        private void coffetimer_CheckedChanged(object sender, EventArgs e)
        {
            if(coffetimer.Checked == true && coffe.active == true)
            {
                coffe.active = false;
                pictureBox2.Image = switchoff;
                currentnum = currentnum - coffe.energy;
                ShwoLabelAndLoad();
            }
        }

        private void lamptimer_CheckedChanged(object sender, EventArgs e)
        {
            if(lamptimer.Checked == true && lamp.active == true)
            {
                lamp.active = false;
                pictureBox3.Image = switchoff;
                currentnum = currentnum - lamp.energy;
                ShwoLabelAndLoad();
            }
        }

        private void refrigeratortimer_CheckedChanged(object sender, EventArgs e)
        {
            if(refrigeratortimer.Checked == true && refrigerator.active == true)
            {
                refrigerator.active = false;
                pictureBox5.Image = switchoff;
                currentnum = currentnum - refrigerator.energy;
                ShwoLabelAndLoad();
            }
        }

        private void heatertimer_CheckedChanged(object sender, EventArgs e)
        {
            if(heatertimer.Checked == true && heater.active == true)
            {
                heater.active = false;
                pictureBox7.Image = switchoff;
                currentnum = currentnum - heater.energy;
                ShwoLabelAndLoad();
            }
        }

        private void radiatortimer_CheckedChanged(object sender, EventArgs e)
        {
            if(radiatortimer.Checked == true && radiator.active == true)
            {
                radiator.active = false;
                pictureBox9.Image = switchoff;
                currentnum = currentnum - radiator.energy;
                ShwoLabelAndLoad();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coffe.timeon = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(comboBox1.SelectedItem.ToString()), Convert.ToInt32(comboBox2.SelectedItem.ToString()), 00);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lamp.timeon = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(comboBox4.SelectedItem.ToString()), Convert.ToInt32(comboBox3.SelectedItem.ToString()), 00);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            refrigerator.timeon = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(comboBox6.SelectedItem.ToString()), Convert.ToInt32(comboBox5.SelectedItem.ToString()), 00);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            heater.timeon = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(comboBox8.SelectedItem.ToString()), Convert.ToInt32(comboBox7.SelectedItem.ToString()), 00);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            radiator.timeon = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(comboBox10.SelectedItem.ToString()), Convert.ToInt32(comboBox9.SelectedItem.ToString()), 00);

        }
    }
    
}
