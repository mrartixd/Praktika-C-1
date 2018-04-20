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
        static double litersnow = 0;

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
                timerlitr.Enabled = false;
                button11.Enabled = false;
                if (radioButton1.Checked == true)
                {
                    pricetext.Text = Convert.ToString(thirdgas.price * Convert.ToInt32(onegastext.Text));
                }
                else if(radioButton2.Checked == true)
                {
                    pricetext.Text = Convert.ToString(onegas.price * Convert.ToInt32(onegastext.Text));
                }
                else if (radioButton3.Checked == true)
                {
                    pricetext.Text = Convert.ToString(twogas.price * Convert.ToInt32(onegastext.Text));
                }
                else if (radioButton4.Checked == true)
                {
                    pricetext.Text = Convert.ToString(fourgas.price * Convert.ToInt32(onegastext.Text));
                }
                


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(onegastext.Text) || twogas.liters < 0 || Convert.ToInt32(twogastext.Text) > twogas.liters)
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
                timerlitr.Enabled = false;
                button9.Enabled = false;
                if (radioButton8.Checked == true)
                {
                    pricetext.Text = Convert.ToString(thirdgas.price * Convert.ToInt32(twogastext.Text));
                }
                else if (radioButton7.Checked == true)
                {
                    pricetext.Text = Convert.ToString(onegas.price * Convert.ToInt32(twogastext.Text));
                }
                else if (radioButton6.Checked == true)
                {
                    pricetext.Text = Convert.ToString(twogas.price * Convert.ToInt32(twogastext.Text));
                }
                else if (radioButton5.Checked == true)
                {
                    pricetext.Text = Convert.ToString(fourgas.price * Convert.ToInt32(twogastext.Text));
                }



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
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
           
            gasline1.Text = Convert.ToString(onegas.typegas + ": liters:" + onegas.liters + ", Price: "+ onegas.price);
            gasline2.Text = Convert.ToString(twogas.typegas + ": liters:" + twogas.liters + ", Price: " + twogas.price);
            gasline3.Text = Convert.ToString(thirdgas.typegas + ": liters:" + thirdgas.liters + ", Price: " + thirdgas.price);
            gasline4.Text = Convert.ToString(fourgas.typegas + ": liters:" + fourgas.liters + ", Price: " + fourgas.price);
            //DisableButton();
            onegastext.Text = Convert.ToString(litersnow);

            if (onegas.active == true && onegas.pay == true)
            {
                sec.Enabled = true;
                
                
                timerkassa.Text = Convert.ToString(num);
            }
        }

        private void sec_Tick(object sender, EventArgs e)
        {
            num--;
            if (num == -1 && onegas.active == true)
            {
                sec.Enabled = false;
               
                num = 10;
                onegas.active = false;
                onegas.pay = false;
                onegas.liters += Convert.ToDouble(onegastext.Text);
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
                ForTimer();
                litersnow = 0;
                button11.Enabled = true;
            }
            
            
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            onegas.price = Convert.ToDouble(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            twogas.price = Convert.ToDouble(textBox2.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            thirdgas.price = Convert.ToDouble(textBox3.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fourgas.price = Convert.ToDouble(textBox4.Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void timerlitr_Tick(object sender, EventArgs e)
        {
            litersnow++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timerlitr.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timerlitr.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true)
            {
                timerlitr.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Choose type of fuel", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true || radioButton7.Checked == true || radioButton6.Checked == true || radioButton5.Checked == true)
            {
                timerlitr.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Choose type of fuel", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
