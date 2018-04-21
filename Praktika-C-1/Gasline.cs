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
        private List<TypeGas> t;
        private bool a;

        public Gasline(int numbergas, List<TypeGas> typegas, bool active)
        {
            this.n = numbergas;
            this.t = typegas;
            this.a = active;
        }

        public Gasline()
        {

        }


        public int numbergas { get => n; set => n = value; }
        public List<TypeGas> typegas { get => t; set => t = value; }
        public bool active { get => a; set => a = value; }

    }
}
