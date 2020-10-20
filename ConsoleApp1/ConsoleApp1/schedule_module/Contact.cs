using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Contact
    {
        public String name { get; set; }
        public String delivery { get; set; }
        public String deliveryHours { get; set; }

        public Contact(string name, string delivery, string deliveryHours)
        {
            this.name = name;
            this.delivery = delivery;
            this.deliveryHours = deliveryHours;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
