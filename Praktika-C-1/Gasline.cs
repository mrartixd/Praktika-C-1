using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_C_1
{
    class Gasline
    {
        private int n;
        private String t;
        private double l;
        private bool a;
        private bool p;
        private double pr;

        public Gasline(int numbergas, String typegas, double liters, bool active , bool pay, double price)
        {
            this.n = numbergas;
            this.t = typegas;
            this.l = liters;
            this.a = active;
            this.p = pay;
            this.pr = price;
        }

        public Gasline()
        {

        }


        public int numbergas { get => n; set => n = value; }
        public String typegas { get => t; set => t = value; }
        public double liters { get => l; set => l = value; }
        public bool active { get => a; set => a = value; }
        public bool pay { get => p; set => p = value; }
        public double price { get => pr; set => pr = value; }
    }
}
