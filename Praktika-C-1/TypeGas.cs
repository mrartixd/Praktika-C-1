using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_C_1
{
    class TypeGas
    {
        private String n;
        private double l;
        private double pr;
        private bool p;

        public TypeGas(String name, double liters, double price, bool pay)
        {
            this.n = name;
            this.l = liters;
            this.pr = price;
            this.p = pay;
        }

        public TypeGas()
        {

        }

        public String name { get => n; set => n = value; }
        public double liters { get => l; set => l = value; }
        public double price { get => pr; set => pr = value; } 
        public bool pay { get => p; set => p = value; }

    }
}
