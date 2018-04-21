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
        static TypeGas bens95 = new TypeGas();
        static TypeGas bens98 = new TypeGas();
        static TypeGas desiel = new TypeGas();
        static TypeGas lpg = new TypeGas();
        static List<TypeGas> listtype;
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
            bens95 = new TypeGas("95",100000,1.38,false);
            bens98 = new TypeGas("98", 100000, 1.45, false);
            desiel = new TypeGas("D", 100000, 1.50, false);
            lpg = new TypeGas("LPG", 100000, 0.60, false);
            listtype.Add(bens95);
            listtype.Add(bens98);
            listtype.Add(desiel);
            listtype.Add(lpg);

            onegas = new Gasline(1, listtype,false);
            twogas = new Gasline(2, listtype,false);
            thirdgas = new Gasline(3, listtype, false);
            fourgas = new Gasline(4, listtype, false);

            
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
            

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            gasline1.Text = Convert.ToString(bens95.name + ": liters:" + bens95.liters + ", Price: "+ bens98.price);
            gasline2.Text = Convert.ToString(bens98.name + ": liters:" + bens98.liters + ", Price: " + bens98.price);
            gasline3.Text = Convert.ToString(desiel.name + ": liters:" + desiel.liters + ", Price: " + desiel.price);
            gasline4.Text = Convert.ToString(lpg.name + ": liters:" + lpg.liters + ", Price: " + lpg.price);
            onegastext.Text = Convert.ToString(litersnow);


            //Check
            if (onegas.active == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
        }

        private void CheckGasTypeTrue(TextBox textBox)
        {
            if(radioButton1.Checked == true || radioButton8.Checked == true)
            {
                desiel.pay = false;
                desiel.liters += Convert.ToDouble(textBox.Text);
            }
            if(radioButton2.Checked == true || radioButton7.Checked == true)
            {
                bens98.pay = false;
                bens98.liters += Convert.ToDouble(textBox.Text);
            }
            if(radioButton3.Checked == true || radioButton6.Checked == true)
            {
                bens95.pay = false;
                bens95.liters += Convert.ToDouble(textBox.Text);
            }
            if(radioButton4.Checked == true || radioButton5.Checked == true)
            {
                lpg.pay = false;
                lpg.liters += Convert.ToDouble(textBox.Text);
            }
        }

        private void CheckGasTypeFalse(TextBox textBox)
        {
            if (radioButton1.Checked == false || radioButton8.Checked == false)
            {
                desiel.pay = true;
                desiel.liters += Convert.ToDouble(textBox.Text);
            }
            if (radioButton2.Checked == true || radioButton7.Checked == true)
            {
                bens98.pay = false;
                bens98.liters += Convert.ToDouble(textBox.Text);
            }
            if (radioButton3.Checked == true || radioButton6.Checked == true)
            {
                bens95.pay = false;
                bens95.liters += Convert.ToDouble(textBox.Text);
            }
            if (radioButton4.Checked == true || radioButton5.Checked == true)
            {
                lpg.pay = false;
                lpg.liters += Convert.ToDouble(textBox.Text);
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
                CheckGasTypeTrue(onegastext);
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
                //onegas.pay = false;
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
            //onegas.price = Convert.ToDouble(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //twogas.price = Convert.ToDouble(textBox2.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //thirdgas.price = Convert.ToDouble(textBox3.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //fourgas.price = Convert.ToDouble(textBox4.Text);
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
