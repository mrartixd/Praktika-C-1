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
        static double kassa = 0;

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
                onegas.liters -= Convert.ToInt32(onegastext.Text);
                onegas.active = true;
                onegas.pay = true;
                sec.Enabled = true;
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
                twogas.liters -= Convert.ToInt32(twogastext.Text);
                twogas.active = true;
                twogas.pay = true;
                sec.Enabled = true;
                pricetext.Text = Convert.ToString(twogas.price * Convert.ToInt32(twogastext.Text));
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
                thirdgas.liters -= Convert.ToInt32(thirdgastext.Text);
                thirdgas.active = true;
                thirdgas.pay = true;
                sec.Enabled = true;
                pricetext.Text = Convert.ToString(thirdgas.price * Convert.ToInt32(thirdgastext.Text));
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
                fourgas.liters -= Convert.ToInt32(fourgastext.Text);
                fourgas.active = true;
                fourgas.pay = true;
                sec.Enabled = true;
                pricetext.Text = Convert.ToString(fourgas.price * Convert.ToInt32(fourgastext.Text));
            }
        }

        private void DisableButton()
        {
            if(onegas.pay == true || twogas.pay == true || thirdgas.pay == true || fourgas.pay == true)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (onegas.pay == false || twogas.pay == false || thirdgas.pay == false || fourgas.pay == false)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            gasname1.Text = onegas.typegas + " Price:"  + Convert.ToString(onegas.price);
            gasname2.Text = twogas.typegas + " Price:" + Convert.ToString(twogas.price);
            gasname3.Text = thirdgas.typegas + " Price:" + Convert.ToString(thirdgas.price);
            gasname4.Text = fourgas.typegas + " Price:" + Convert.ToString(fourgas.price);
            progressBar1.Value = Convert.ToInt32(onegas.liters);
            progressBar2.Value = Convert.ToInt32(twogas.liters);
            progressBar3.Value = Convert.ToInt32(thirdgas.liters);
            progressBar4.Value = Convert.ToInt32(fourgas.liters);
            gasline1.Text = Convert.ToString(onegas.typegas + ": liters:" + onegas.liters + ", active:" + onegas.active + ", pay:" + onegas.pay);
            gasline2.Text = Convert.ToString(twogas.typegas + ": liters:" + twogas.liters + ", active:" + twogas.active + ", pay:" + twogas.pay);
            gasline3.Text = Convert.ToString(thirdgas.typegas + ": liters:" + thirdgas.liters + ", active:" + thirdgas.active + ", pay:" + thirdgas.pay);
            gasline4.Text = Convert.ToString(fourgas.typegas + ": liters:" + fourgas.liters + ", active:" + fourgas.active + ", pay:" + fourgas.pay);
            DisableButton();


            if (onegas.active == true && onegas.pay == true)
            {
                sec.Enabled = true;
                onegastext.Enabled = false;
                timerkassa.Text = Convert.ToString(num);
            }
            if(twogas.active == true && twogas.pay == true)
            {
                sec.Enabled = true;
                twogastext.Enabled = false;
                timerkassa.Text = Convert.ToString(num);
            }
        }

        private void sec_Tick(object sender, EventArgs e)
        {
            num--;
            if (num == -1 && onegas.active == true)
            {
                sec.Enabled = false;
                onegastext.Enabled = true;
                num = 10;
                onegas.active = false;
                onegas.pay = false;
                onegas.liters += Convert.ToDouble(onegastext.Text);
            }
            if( num == -1 && twogas.active == true)
            {
                sec.Enabled = false;
                twogastext.Enabled = true;
                num = 10;
                twogas.active = false;
                twogas.pay = false;
                twogas.liters += Convert.ToDouble(twogastext.Text);
            }
            if(num == -1 && thirdgas.active == true)
            {
                sec.Enabled = false;
                thirdgastext.Enabled = false;
                num = 10;
                thirdgas.active = false;
                thirdgas.pay = false;
                thirdgas.liters += Convert.ToDouble(thirdgastext.Text);
            }
            if (num == -1 && fourgas.active == true)
            {
                sec.Enabled = false;
                fourgastext.Enabled = false;
                num = 10;
                fourgas.active = false;
                fourgas.pay = false;
                fourgas.liters += Convert.ToDouble(fourgastext.Text);
            }
        }
        private void ForTimer()
        {
            sec.Enabled = false;
            num = 10;
            kassa += Convert.ToDouble(pricetext.Text);
            labelkassa.Text = Convert.ToString(kassa);
            pricetext.Text = "0";
        }

        private void paybutton_Click(object sender, EventArgs e)
        {
            if(onegastext.Enabled == false)
            {
                onegas.active = false;
                onegas.pay = false;
                onegastext.Enabled = true;
                ForTimer();
            }
            if(twogastext.Enabled == false)
            {
                twogas.active = false;
                twogas.pay = false;
                twogastext.Enabled = true;
                ForTimer();
            }
            if(thirdgastext.Enabled == false)
            {
                thirdgas.active = false;
                thirdgas.pay = false;
                thirdgastext.Enabled = true;
                ForTimer();
            }
            if(fourgastext.Enabled == false)
            {
                fourgas.active = false;
                fourgas.pay = false;
                fourgastext.Enabled = true;
                ForTimer();
            }
            
            
        }
    }
}
