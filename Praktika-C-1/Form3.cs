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
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label10.Visible = false;
            named.Visible = false;
            energyd.Visible = false;
            timerd.Visible = false;
            actived.Visible = false;
        }
        private void VisibleInfo()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label10.Visible = true;
            named.Visible = true;
            energyd.Visible = true;
            timerd.Visible = true;
            actived.Visible = true;
        }

        private void secondtask_Load(object sender, EventArgs e)
        {
            current.Text = Convert.ToString(currentnum);
            InvisibleInfo();
            lamp = new Device("Lamps", 20, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 30, 00), false);
            radiator = new Device("Radiator", 2000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 00, 00), false);
            heater = new Device("Water Heater", 8000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 00, 00), false);
            coffe = new Device("Coffe machine", 400, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 15, 00), false);
            refrigerator = new Device("Refrigerator", 110, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00), false);
        }

        private void CheckCurrentLabel()
        {
            if(currentnum < 0)
            {
                currentnum = 0;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (coffe.getActive() == false)
            {
                current.Text = Convert.ToString(currentnum + coffe.getEnergy());
                coffe.setActive(true);
                pictureBox2.Image = switchon;
            }
            else
            {
                current.Text = Convert.ToString(currentnum - coffe.getEnergy());
                coffe.setActive(false);
                pictureBox2.Image = switchoff;
            }
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(lamp.getActive()==false)
            {
                lamp.setActive(true);
                pictureBox3.Image = switchon;
            }
            else
            {
                lamp.setActive(false);
                pictureBox3.Image = switchoff;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (refrigerator.getActive() == false)
            {
                refrigerator.setActive(true);
                pictureBox5.Image = switchon;
            }
            else
            {
                refrigerator.setActive(false);
                pictureBox5.Image = switchoff;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (heater.getActive() == false)
            {
                current.Text = Convert.ToString(currentnum + heater.getEnergy());
                heater.setActive(true);
                pictureBox7.Image = switchon;
            }
            else
            {
                current.Text = Convert.ToString(currentnum - heater.getEnergy());
                heater.setActive(false);
                pictureBox7.Image = switchoff;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (radiator.getActive() == false)
            {
                radiator.setActive(true);
                pictureBox9.Image = switchon;
            }
            else
            {
                radiator.setActive(false);
                pictureBox9.Image = switchoff;
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            VisibleInfo();
            named.Text = coffe.getNameDevice();
            energyd.Text = Convert.ToString(coffe.getEnergy()/1000 + " watt");
            timerd.Text = Convert.ToString(coffe.getDateTime());
            
            if (coffe.getActive() == true)
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
    }
}
