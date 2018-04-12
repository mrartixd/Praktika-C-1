using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_C_1
{
    class Event
    {
        public String nameevent { get => nameevent; set => nameevent = value; }
        public DateTime dateevent { get => dateevent; set => dateevent = value; }
        public String timer { get => timer; set => timer = value; }

        public Event(String name, DateTime date, String timer)
        {
            this.nameevent = name;
            this.dateevent = date;
            this.timer = timer;
        }

    }
}
