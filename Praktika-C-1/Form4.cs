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
        static List<TypeGas> listtype = new List<TypeGas>();
        static int num = 10;
        static double kassa = 0;
        static double litersnow1 = 0;
        static double litersnow2 = 0;
        static double litersnow3 = 0;
        static double litersnow4 = 0;


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
        private void button1_Click(object sender, EventArgs e)
        {
                if (radioButton1.Checked == true)
                {
                    pricetext.Text = Convert.ToString(desiel.price * Convert.ToDouble(onegastext.Text));
                    
                    desiel.pay = true;
                    sec.Enabled = true;
                    timerlitr.Enabled = false;
                    
                }
                else if(radioButton2.Checked == true)
                {
                    pricetext.Text = Convert.ToString(bens98.price * Convert.ToDouble(onegastext.Text));
                    
                   
                    bens98.pay = true;
                    sec.Enabled = true;
                    timerlitr.Enabled = false;
                  
                }
                else if (radioButton3.Checked == true)
                {
                    pricetext.Text = Convert.ToString(bens95.price * Convert.ToDouble(onegastext.Text));
                   
                    
                    bens95.pay = true;
                    sec.Enabled = true;
                    timerlitr.Enabled = false;
                  
                }
                else if (radioButton4.Checked == true)
                {
                    pricetext.Text = Convert.ToString(lpg.price * Convert.ToDouble(onegastext.Text));
                    
                    
                    lpg.pay = true;
                    sec.Enabled = true;
                    timerlitr.Enabled = false;
                 
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton8.Checked == true)
            {
                pricetext.Text = Convert.ToString(desiel.price * Convert.ToDouble(twogastext.Text));


                desiel.pay = true;
                sec.Enabled = true;
                timerlitr.Enabled = false;
                
            }
            else if (radioButton7.Checked == true)
            {
                pricetext.Text = Convert.ToString(bens98.price * Convert.ToDouble(twogastext.Text));


                bens98.pay = true;
                sec.Enabled = true;
                timerlitr.Enabled = false;
                
            }
            else if (radioButton6.Checked == true)
            {
                pricetext.Text = Convert.ToString(bens95.price * Convert.ToDouble(twogastext.Text));


                bens95.pay = true;
                sec.Enabled = true;
                timerlitr.Enabled = false;
               
            }
            else if (radioButton5.Checked == true)
            {
                pricetext.Text = Convert.ToString(lpg.price * Convert.ToDouble(twogastext.Text));


                lpg.pay = true;
                sec.Enabled = true;
                timerlitr.Enabled = false;
               
            }

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
            onegastext.Text = litersnow1.ToString("F");
            twogastext.Text = litersnow2.ToString("F");
            thirdgastext.Text = litersnow3.ToString("F");
            fourgastext.Text = litersnow4.ToString("F");


            //Check
            if (onegas.active == true && desiel.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            if (onegas.active == true && bens95.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            if (onegas.active == true && bens98.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            if (onegas.active == true && lpg.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            //
            if (twogas.active == true && desiel.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            if (twogas.active == true && bens95.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            if (twogas.active == true && bens98.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            if (twogas.active == true && lpg.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            //
            if (thirdgas.active == true && desiel.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            if (thirdgas.active == true && bens95.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            if (thirdgas.active == true && bens98.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            if (thirdgas.active == true && lpg.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            //
            if (fourgas.active == true && desiel.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            if (fourgas.active == true && bens95.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            if (fourgas.active == true && bens98.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
            if (fourgas.active == true && lpg.pay == true)
            {
                sec.Enabled = true;
                timerkassa.Text = Convert.ToString(num);
            }
        }

        private void CheckGasTypeTrue(TextBox textBox)
        {
            if(radioButton1.Checked == true || radioButton8.Checked == true || radioButton12.Checked == true || radioButton16.Checked == true)
            {
                desiel.pay = false;
                
            }
            if(radioButton2.Checked == true || radioButton7.Checked == true || radioButton11.Checked == true || radioButton15.Checked == true)
            {
                bens98.pay = false;
                
            }
            if(radioButton3.Checked == true || radioButton6.Checked == true || radioButton10.Checked == true || radioButton14.Checked == true)
            {
                bens95.pay = false;
                
            }
            if(radioButton4.Checked == true || radioButton5.Checked == true || radioButton9.Checked == true || radioButton13.Checked == true)
            {
                lpg.pay = false;
                
            }
        }

        private void CheckGasTypeFalse(TextBox textBox)
        {
            if (radioButton1.Checked == false || radioButton8.Checked == false || radioButton12.Checked == false  || radioButton16.Checked == false)
            {
                desiel.pay = true;
                
            }
            if (radioButton2.Checked == true || radioButton7.Checked == true || radioButton11.Checked == false || radioButton15.Checked == false)
            {
                bens98.pay = false;
                
            }
            if (radioButton3.Checked == true || radioButton6.Checked == true || radioButton10.Checked == false || radioButton14.Checked == false)
            {
                bens95.pay = false;
                
            }
            if (radioButton4.Checked == true || radioButton5.Checked == true || radioButton9.Checked == false || radioButton13.Checked == false)
            {
                lpg.pay = false;
                
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
                litersnow1 = 0;
                CheckGasTypeTrue(onegastext);
                button1.Enabled = false;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
                
            }
            if (num == -1 && twogas.active == true)
            {
                sec.Enabled = false;
                num = 10;
                twogas.active = false;
                litersnow2 = 0;
                CheckGasTypeTrue(twogastext);
                button2.Enabled = false;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
            }
            if (num == -1 && thirdgas.active == true)
            {
                sec.Enabled = false;
                num = 10;
                thirdgas.active = false;
                litersnow3 = 0;
                CheckGasTypeTrue(thirdgastext);
                button4.Enabled = false;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();

            }
            if (num == -1 && fourgas.active == true)
            {
                sec.Enabled = false;
                num = 10;
                fourgas.active = false;
                litersnow4 = 0;
                CheckGasTypeTrue(fourgastext);
                button13.Enabled = false;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
            }

        }


        private void ForTimer()
        {
            sec.Enabled = false;
            num = 10;
            
            labelkassa.Text = Convert.ToString(kassa);
            pricetext.Text = "0";
        }

        private void paybutton_Click(object sender, EventArgs e)
        {
            if(onegas.active == true && desiel.pay == true)
            {
                desiel.liters -= Convert.ToDouble(onegastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                onegas.active = false;
                desiel.pay = false;
                ForTimer();
                litersnow1 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button1.Enabled = false;
            }
            if(onegas.active == true && bens98.pay == true)
            {
                bens98.liters -= Convert.ToDouble(onegastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                onegas.active = false;
                bens98.pay = false;
                ForTimer();
                litersnow1 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button1.Enabled = false;
            }
            if (onegas.active == true && bens95.pay == true)
            {
                bens95.liters -= Convert.ToDouble(onegastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                onegas.active = false;
                bens95.pay = false;
                ForTimer();
                litersnow1 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button1.Enabled = false;
            }
            if (onegas.active == true && lpg.pay == true)
            {
                lpg.liters -= Convert.ToDouble(onegastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                onegas.active = false;
                lpg.pay = false;
                ForTimer();
                litersnow1 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button1.Enabled = false;
            }
            //
            if (twogas.active == true && desiel.pay == true)
            {
                desiel.liters -= Convert.ToDouble(twogastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                twogas.active = false;
                desiel.pay = false;
                ForTimer();
                litersnow2 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button2.Enabled = false;
            }
            if (twogas.active == true && bens98.pay == true)
            {
                bens98.liters -= Convert.ToDouble(twogastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                twogas.active = false;
                bens98.pay = false;
                ForTimer();
                litersnow2 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button2.Enabled = false;
            }
            if (twogas.active == true && bens95.pay == true)
            {
                bens95.liters -= Convert.ToDouble(twogastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                twogas.active = false;
                bens95.pay = false;
                ForTimer();
                litersnow2 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button2.Enabled = false;
            }
            if (twogas.active == true && lpg.pay == true)
            {
                lpg.liters -= Convert.ToDouble(twogastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                twogas.active = false;
                lpg.pay = false;
                ForTimer();
                litersnow2 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button2.Enabled = false;
            }
            //
            if (thirdgas.active == true && desiel.pay == true)
            {
                desiel.liters -= Convert.ToDouble(thirdgastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                thirdgas.active = false;
                desiel.pay = false;
                ForTimer();
                litersnow3 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button4.Enabled = false;
            }
            if (thirdgas.active == true && bens98.pay == true)
            {
                bens98.liters -= Convert.ToDouble(thirdgastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                thirdgas.active = false;
                bens98.pay = false;
                ForTimer();
                litersnow3 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button4.Enabled = false;
            }
            if (thirdgas.active == true && bens95.pay == true)
            {
                bens95.liters -= Convert.ToDouble(thirdgastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                thirdgas.active = false;
                bens95.pay = false;
                ForTimer();
                litersnow3 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button4.Enabled = false;
            }
            if (thirdgas.active == true && lpg.pay == true)
            {
                lpg.liters -= Convert.ToDouble(thirdgastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                thirdgas.active = false;
                lpg.pay = false;
                ForTimer();
                litersnow3 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button4.Enabled = false;
            }
            //
            if (fourgas.active == true && desiel.pay == true)
            {
                desiel.liters -= Convert.ToDouble(fourgastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                fourgas.active = false;
                desiel.pay = false;
                ForTimer();
                litersnow4 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button13.Enabled = false;
            }
            if (fourgas.active == true && bens98.pay == true)
            {
                bens98.liters -= Convert.ToDouble(fourgastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                fourgas.active = false;
                bens98.pay = false;
                ForTimer();
                litersnow4 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button13.Enabled = false;
            }
            if (fourgas.active == true && bens95.pay == true)
            {
                bens95.liters -= Convert.ToDouble(fourgastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                fourgas.active = false;
                bens95.pay = false;
                ForTimer();
                litersnow4 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button13.Enabled = false;
            }
            if (fourgas.active == true && lpg.pay == true)
            {
                lpg.liters -= Convert.ToDouble(fourgastext.Text);
                kassa += Convert.ToDouble(pricetext.Text);
                fourgas.active = false;
                lpg.pay = false;
                ForTimer();
                litersnow4 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button13.Enabled = false;
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
            if(onegas.active == true)
            {
                litersnow1+= 0.010;
            }
            else if (twogas.active == true)
            {
                litersnow2+= 0.010;
            }
            else if(thirdgas.active == true)
            {
                litersnow3+= 0.010;
            }
            else
            {
                litersnow4+= 0.010;
            }
            
           
            
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
                onegas.active = true;
                DisableStart();
               
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
                twogas.active = true;
                DisableStart();
            }
            else
            {
                MessageBox.Show("Choose type of fuel", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true || radioButton11.Checked == true || radioButton10.Checked == true || radioButton9.Checked == true)
            {
                timerlitr.Enabled = true;
                button4.Enabled = true;
                thirdgas.active = true;
                DisableStart();
            }
            else
            {
                MessageBox.Show("Choose type of fuel", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (onegas.active == true && desiel.pay == true)
            {
                
                onegas.active = false;
                desiel.pay = false;
                ForTimer();
                litersnow1 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
                
                button1.Enabled = false;
            }
            if (onegas.active == true && bens95.pay == true)
            {

                onegas.active = false;
                bens95.pay = false;
                ForTimer();
                litersnow1 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();

                button1.Enabled = false;
            }
            if (onegas.active == true && bens98.pay == true)
            {

                onegas.active = false;
                bens98.pay = false;
                ForTimer();
                litersnow1 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();

                button1.Enabled = false;
            }
            if (onegas.active == true && lpg.pay == true)
            {

                onegas.active = false;
                lpg.pay = false;
                ForTimer();
                litersnow1 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
                button1.Enabled = false;
            }
            //
            if (twogas.active == true && desiel.pay == true)
            {

                twogas.active = false;
                desiel.pay = false;
                ForTimer();
                litersnow2 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
                button2.Enabled = false;
            }
            if (twogas.active == true && bens95.pay == true)
            {

                twogas.active = false;
                bens95.pay = false;
                ForTimer();
                litersnow2 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
                button2.Enabled = false;
            }
            if (twogas.active == true && bens98.pay == true)
            {

                twogas.active = false;
                bens98.pay = false;
                ForTimer();
                litersnow2 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
                button2.Enabled = false;
            }
            if (twogas.active == true && lpg.pay == true)
            {

                twogas.active = false;
                lpg.pay = false;
                ForTimer();
                litersnow2 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
                button2.Enabled = false;
            }
            //
            if (thirdgas.active == true && desiel.pay == true)
            {

                thirdgas.active = false;
                desiel.pay = false;
                ForTimer();
                litersnow3 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button4.Enabled = false;
            }
            if (thirdgas.active == true && bens95.pay == true)
            {

                thirdgas.active = false;
                bens95.pay = false;
                ForTimer();
                litersnow3 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button4.Enabled = false;
            }
            if (thirdgas.active == true && bens98.pay == true)
            {

                thirdgas.active = false;
                bens98.pay = false;
                ForTimer();
                litersnow3 = 0;
                timerkassa.Text = "10";
                DisableStart();
                button4.Enabled = false;
            }
            if (thirdgas.active == true && lpg.pay == true)
            {

                thirdgas.active = false;
                lpg.pay = false;
                ForTimer();
                litersnow3 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
                button4.Enabled = false;
            }
            //
            if (fourgas.active == true && desiel.pay == true)
            {

                fourgas.active = false;
                desiel.pay = false;
                ForTimer();
                litersnow4 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
                button13.Enabled = false;
            }
            if (fourgas.active == true && bens95.pay == true)
            {

                fourgas.active = false;
                bens95.pay = false;
                ForTimer();
                litersnow4 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
                button13.Enabled = false;
            }
            if (fourgas.active == true && bens98.pay == true)
            {

                fourgas.active = false;
                bens98.pay = false;
                ForTimer();
                litersnow4 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
                button4.Enabled = false;
            }
            if (fourgas.active == true && lpg.pay == true)
            {

                fourgas.active = false;
                lpg.pay = false;
                ForTimer();
                litersnow4 = 0;
                timerkassa.Text = "10";
                pricetext.Text = "0";
                DisableStart();
                button4.Enabled = false;
            }

        }
        private void DisableStart()
        {
            if(button11.Enabled == true || button9.Enabled == true)
            {
                button11.Enabled = false;
                button9.Enabled = false;
                button3.Enabled = false;
                button12.Enabled = false;
            }
            else
            {
                button11.Enabled = true;
                button9.Enabled = true;
                button3.Enabled = true;
                button12.Enabled = true;
            }
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                pricetext.Text = Convert.ToString(desiel.price * Convert.ToDouble(thirdgastext.Text));
                desiel.pay = true;
                sec.Enabled = true;
                timerlitr.Enabled = false;
               
            }
            else if (radioButton11.Checked == true)
            {
                pricetext.Text = Convert.ToString(bens98.price * Convert.ToDouble(thirdgastext.Text));
                bens98.pay = true;
                sec.Enabled = true;
                timerlitr.Enabled = false;
                
            }
            else if (radioButton10.Checked == true)
            {
                pricetext.Text = Convert.ToString(bens95.price * Convert.ToDouble(thirdgastext.Text));
                bens95.pay = true;
                sec.Enabled = true;
                timerlitr.Enabled = false;
                
            }
            else if (radioButton9.Checked == true)
            {
                pricetext.Text = Convert.ToString(lpg.price * Convert.ToDouble(thirdgastext.Text));
                lpg.pay = true;
                sec.Enabled = true;
                timerlitr.Enabled = false;
                
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true || radioButton15.Checked == true || radioButton14.Checked == true || radioButton13.Checked == true)
            {
                timerlitr.Enabled = true;
                button13.Enabled = true;
                fourgas.active = true;
                DisableStart();

            }
            else
            {
                MessageBox.Show("Choose type of fuel", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                pricetext.Text = Convert.ToString(desiel.price * Convert.ToDouble(fourgastext.Text));
                desiel.pay = true;
                sec.Enabled = true;
                timerlitr.Enabled = false;
               
            }
            else if (radioButton15.Checked == true)
            {
                pricetext.Text = Convert.ToString(bens98.price * Convert.ToDouble(fourgastext.Text));
                bens98.pay = true;
                sec.Enabled = true;
                timerlitr.Enabled = false;
               
            }
            else if (radioButton14.Checked == true)
            {
                pricetext.Text = Convert.ToString(bens95.price * Convert.ToDouble(fourgastext.Text));
                bens95.pay = true;
                sec.Enabled = true;
                timerlitr.Enabled = false;
               
            }
            else if (radioButton13.Checked == true)
            {
                pricetext.Text = Convert.ToString(lpg.price * Convert.ToDouble(fourgastext.Text));
                lpg.pay = true;
                sec.Enabled = true;
                timerlitr.Enabled = false;
               
            }
        }
    }
}
