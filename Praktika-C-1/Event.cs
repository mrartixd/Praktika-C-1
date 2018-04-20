using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_C_1
{
    class Event
    {
        private String n;
        private DateTime d;
        private String t;
        

        public Event(String nameevent, DateTime dateevent, String timeoff)
        {
            this.n = nameevent;
            this.d = dateevent;
            this.t = timeoff;
        }

        public Event()
        {

        }

        public String nameevent { get => n; set => n = value; }
        public DateTime dateevent { get => d; set => d = value; }
        public String timeoff { get => t; set => t = value; }

    }
}
