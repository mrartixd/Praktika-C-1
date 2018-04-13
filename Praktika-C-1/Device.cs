using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_C_1
{
    class Device
    {
        private String device;
        private double electr;
        private DateTime date;
        private bool activate;

        public Device(String namedevice, double energy, DateTime timeon, bool active)
        {
            this.device = namedevice;
            this.electr = energy;
            this.date = timeon;
            this.activate = active;
        }

        public Device()
        {
        }

        public String namedevice { get => device; set => device = value; }
        public double energy { get => electr; set => electr = value; }
        public DateTime timeon { get => date; set => date = value; }
        public Boolean active { get => activate; set => activate = value; }
    }

}
