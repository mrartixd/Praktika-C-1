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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void first_Click(object sender, EventArgs e)
        {
            first.Enabled = false;
            firsttask fi = new firsttask();
            fi.Owner = this;
            fi.Show();
        }

        private void secont_Click(object sender, EventArgs e)
        {
            second.Enabled = false;
            secondtask se = new secondtask();
            se.Owner = this;
            se.Show();
        }

        private void third_Click(object sender, EventArgs e)
        {
            third.Enabled = false;
            thirdtask th = new thirdtask();
            th.Owner = this;
            th.Show();
        }
    }
}
