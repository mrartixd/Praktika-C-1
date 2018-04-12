using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_C_1
{
    class Device
    {
        private String namedevice;
        private double energy;
        private DateTime timeon = new DateTime();
        private Boolean active = false;

        public DateTime Timeon { get => timeon; set => timeon = value; }

        public Device(String namedevice, double energy, DateTime timeon, bool active)
        {
            this.namedevice = namedevice;
            this.energy = energy;
            this.Timeon = timeon;
            this.active = active;
        }

        public Device()
        {
        }

        public void setNameDevice(String name)
        {
            namedevice = name;
        }

        public void setEnergy(double number)
        {
            energy = number;
        }

        public void setTimeOn(DateTime time)
        {
            Timeon = time;
        }

        public void setActive(Boolean turn)
        {
            active = turn;
        }

        public Boolean getActive()
        {
            return active;
        }

        public String getNameDevice()
        {
            return namedevice;
        }

        public double getEnergy()
        {
            return energy;
        }

        public DateTime getDateTime()
        {
            return Timeon;
        }
    }
}
