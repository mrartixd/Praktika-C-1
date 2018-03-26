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
        public secondtask()
        {
            InitializeComponent();

        }
        
        private void secondtask_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as Form1).second.Enabled = true;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //   if (radiator.getActive() == false)
        //    {
        //        radiator.setActive(true);
        //    }
        //   else
        //    {
        //        radiator.setActive(false);
        //    }
        //}

        private void secondtask_Load(object sender, EventArgs e)
        {
            lamp = new Device("Lamps", 20, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 30, 00), false);
            radiator = new Device("Radiator", 2000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 00, 00), false);
            heater = new Device("Water Heater", 8000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 00, 00), false);
            coffe = new Device("Coffe machine", 400, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 15, 00), false);
            refrigerator = new Device("Refrigerator", 110, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00), false);

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            named.Text = lamp.getNameDevice();
            energyd.Text = Convert.ToString(lamp.getEnergy());
            dated.Text = Convert.ToString(lamp.getDateTime());
            if (lamp.getActive() == true)
            {
                actived.Text = "active";
            }
            else
            {
                actived.Text = "turnoff";
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            named.Text = heater.getNameDevice();
            energyd.Text = Convert.ToString(heater.getEnergy());
            dated.Text = Convert.ToString(heater.getDateTime());
            if (heater.getActive() == true)
            {
                actived.Text = "active";
            }
            else
            {
                actived.Text = "turnoff";
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            named.Text = radiator.getNameDevice();
            energyd.Text = Convert.ToString(radiator.getEnergy());
            dated.Text = Convert.ToString(radiator.getDateTime());
            if (radiator.getActive() == true)
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
            named.Text = coffe.getNameDevice();
            energyd.Text = Convert.ToString(coffe.getEnergy());
            dated.Text = Convert.ToString(coffe.getDateTime());
            if (coffe.getActive() == true)
            {
                actived.Text = "active";
            }
            else
            {
                actived.Text = "turnoff";
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            named.Text = refrigerator.getNameDevice();
            energyd.Text = Convert.ToString(refrigerator.getEnergy());
            dated.Text = Convert.ToString(refrigerator.getDateTime());
            if (refrigerator.getActive() == true)
            {
                actived.Text = "active";
            }
            else
            {
                actived.Text = "turnoff";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (radiator.getActive() == false)
            {
                radiator.setActive(true);
                pictureBox6.Image = Properties.Resources.switchon;
            }
            else
            {
                radiator.setActive(false);
                pictureBox6.Image = Properties.Resources.switchoff;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (heater.getActive() == false)
            {
                heater.setActive(true);
                pictureBox7.Image = Properties.Resources.switchon;
            }
            else
            {
                heater.setActive(false);
                pictureBox7.Image = Properties.Resources.switchoff;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (lamp.getActive() == false)
            {
                lamp.setActive(true);
                pictureBox8.Image = Properties.Resources.switchon;
            }
            else
            {
                lamp.setActive(false);
                pictureBox8.Image = Properties.Resources.switchoff;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (coffe.getActive() == false)
            {
                coffe.setActive(true);
                pictureBox9.Image = Properties.Resources.switchon;
            }
            else
            {
                coffe.setActive(false);
                pictureBox9.Image = Properties.Resources.switchoff;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (refrigerator.getActive() == false)
            {
                refrigerator.setActive(true);
                pictureBox10.Image = Properties.Resources.switchon;
            }
            else
            {
                refrigerator.setActive(false);
                pictureBox10.Image = Properties.Resources.switchoff;
            }
        }
    }
}
