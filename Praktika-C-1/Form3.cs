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
        public secondtask()
        {
            InitializeComponent();
        }

        private void secondtask_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as Form1).second.Enabled = true;
        }
    }
}
