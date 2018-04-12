using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_C_1
{
    class Device
    {
        public Device(String namedevice, double energy, DateTime timeon, bool active)
        {
            this.namedevice = namedevice;
            this.energy = energy;
            this.timeon = timeon;
            this.active = active;
        }

        public Device()
        {
        }

        public String namedevice { get => namedevice; set => namedevice = value; }
        public double energy { get => energy; set => energy = value; }
        public DateTime timeon { get => timeon; set => timeon = value; }
        public Boolean active { get => active; set => active = value; }
    }

}
