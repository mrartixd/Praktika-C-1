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
            current.Text = Convert.ToString(currentnum);
            InvisibleInfo();
            lamp = new Device("Lamps", 20, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 30, 00), false);
            radiator = new Device("Radiator", 2000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 00, 00), false);
            heater = new Device("Water Heater", 8000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 00, 00), false);
            coffe = new Device("Coffe machine", 400, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 15, 00), false);
            refrigerator = new Device("Refrigerator", 110, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00), false);
            coffetimer.Text = Convert.ToString(coffe.getDateTime());
        }

        private void ShwoLabelAndLoad()
        {
            current.Text = Convert.ToString(currentnum + " kWh");
            loadbar.Value = Convert.ToInt32(currentnum);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (coffe.getActive() == false)
            {
                currentnum = currentnum + coffe.getEnergy();
                coffe.setActive(true);
                pictureBox2.Image = switchon;
            }
            else
            {
                currentnum = currentnum - coffe.getEnergy();
                coffe.setActive(false);
                pictureBox2.Image = switchoff;
            }
            ShwoLabelAndLoad();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (lamp.getActive() == false)
            {
                currentnum = currentnum + lamp.getEnergy();
                lamp.setActive(true);
                pictureBox3.Image = switchon;
            }
            else
            {
                currentnum = currentnum - lamp.getEnergy();
                lamp.setActive(false);
                pictureBox3.Image = switchoff;
            }
            ShwoLabelAndLoad();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (refrigerator.getActive() == false)
            {
                currentnum = currentnum + refrigerator.getEnergy();
                refrigerator.setActive(true);
                pictureBox5.Image = switchon;
            }
            else
            {
                currentnum = currentnum - refrigerator.getEnergy();
                refrigerator.setActive(false);
                pictureBox5.Image = switchoff;
            }
            ShwoLabelAndLoad();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (heater.getActive() == false)
            {
                currentnum = currentnum + heater.getEnergy();
                heater.setActive(true);
                pictureBox7.Image = switchon;
            }
            else
            {
                currentnum = currentnum - heater.getEnergy();
                heater.setActive(false);
                pictureBox7.Image = switchoff;
            }
            ShwoLabelAndLoad();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (radiator.getActive() == false)
            {
                currentnum = currentnum + radiator.getEnergy();
                radiator.setActive(true);
                pictureBox9.Image = switchon;
            }
            else
            {
                currentnum = currentnum - radiator.getEnergy();
                radiator.setActive(false);
                pictureBox9.Image = switchoff;
            }
            ShwoLabelAndLoad();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            VisibleInfo();
            named.Text = coffe.getNameDevice();
            energyd.Text = Convert.ToString(coffe.getEnergy() / 1000 + " kWh");
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

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            VisibleInfo();
            named.Text = lamp.getNameDevice();
            energyd.Text = Convert.ToString(lamp.getEnergy() / 1000 + " kWh");
            timerd.Text = Convert.ToString(lamp.getDateTime());

            if (lamp.getActive() == true)
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
            named.Text = refrigerator.getNameDevice();
            energyd.Text = Convert.ToString(refrigerator.getEnergy() / 1000 + " kWh");
            timerd.Text = Convert.ToString(refrigerator.getDateTime());

            if (refrigerator.getActive() == true)
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
            named.Text = heater.getNameDevice();
            energyd.Text = Convert.ToString(heater.getEnergy() / 1000 + " kWh");
            timerd.Text = Convert.ToString(heater.getDateTime());

            if (heater.getActive() == true)
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
            named.Text = radiator.getNameDevice();
            energyd.Text = Convert.ToString(radiator.getEnergy() / 1000 + " kWh");
            timerd.Text = Convert.ToString(radiator.getDateTime());
            if (radiator.getActive() == true)
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
