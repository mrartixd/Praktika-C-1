using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Artur Shbaunov RDIR61
 *  Kujundada vorm, millel saab sisestada mingi sündmuse kuupäeva ja algusaja. Kontrollida, et sisestatud aeg on tulevikus.
 *  Pärast aja sisestamist seda enam muuta ei saa. Kuvada jooksvalt sündmuseni jäänud aega päevades, tundides, 
 *  minutites ja sekundites. Uuendada kuvatavat aega kord sekundis.
 * 
 */

namespace Praktika_C_1
{
    public partial class W : Form
    {
        public W()
        {
            InitializeComponent();
        }

        private void firsttask_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as Form1).first.Enabled = true;
        }
    }
}
