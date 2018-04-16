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
    public partial class thirdtask : Form
    {
        static Gasline onegas = new Gasline();
        static Gasline twogas = new Gasline();
        static Gasline thirdgas = new Gasline();
        static Gasline fourgas = new Gasline();
        static int num = 10;

        public thirdtask()
        {
            InitializeComponent();
        }

        

        private void thirdtask_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as Form1).third.Enabled = true;
        }

        private void thirdtask_Load(object sender, EventArgs e)
        {
            onegas = new Gasline(1, "98", 10000, false, false, 1.38);
            twogas = new Gasline(2, "95", 10000, false, false, 1.40);
            thirdgas = new Gasline(3, "D", 10000, false, false, 1.41);
            fourgas = new Gasline(4, "LPG", 10000, false, false, 0.69);

            progressBar1.Value = Convert.ToInt32(onegas.liters);
            progressBar2.Value = Convert.ToInt32(twogas.liters);
            progressBar3.Value = Convert.ToInt32(thirdgas.liters);
            progressBar4.Value = Convert.ToInt32(fourgas.liters);
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(onegastext.Text) || onegas.liters < 0 || Convert.ToInt32(onegastext.Text) > onegas.liters) 
            {
                MessageBox.Show("Fuel out of range", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                onegas.liters = onegas.liters - Convert.ToInt32(onegastext.Text);
                progressBar1.Value = Convert.ToInt32(onegas.liters);
                onegas.active = true;
                onegas.pay = true;
                timer1.Start();
                pricetext.Text = Convert.ToString(onegas.price * Convert.ToInt32(onegastext.Text));
            }
        }

        private void onegastext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void twogastext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void thirdgastext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void fourgastext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(twogastext.Text) || twogas.liters < 0 || Convert.ToInt32(twogastext.Text) > twogas.liters)
            {
                MessageBox.Show("Fuel out of range", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                twogas.liters = twogas.liters - Convert.ToInt32(twogastext.Text);
                progressBar2.Value = Convert.ToInt32(twogas.liters);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(thirdgastext.Text) || thirdgas.liters < 0 || Convert.ToInt32(thirdgastext.Text) > thirdgas.liters)
            {
                MessageBox.Show("Fuel out of range", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                thirdgas.liters = thirdgas.liters - Convert.ToInt32(thirdgastext.Text);
                progressBar3.Value = Convert.ToInt32(thirdgas.liters);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fourgastext.Text) || fourgas.liters < 0 || Convert.ToInt32(fourgastext.Text) > fourgas.liters)
            {
                MessageBox.Show("Fuel out of range", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fourgas.liters = fourgas.liters - Convert.ToInt32(fourgastext.Text);
                progressBar4.Value = Convert.ToInt32(fourgas.liters);
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        { 
            if(onegas.active == true && onegas.pay == false)
            {
                timerkassa.Text = Convert.ToString(num);
                sec.Enabled = true;
                button1.Enabled = false;
                onegastext.Enabled = false;
                
            }
        }

        private void sec_Tick(object sender, EventArgs e)
        {
            num--;
            if (num == -1)
            {
                timer1.Stop();
                num = 60;
                button1.Enabled = true;
                onegastext.Enabled = true;
                onegas.active = false;
                onegas.pay = false;
            }
        }
    }
}
