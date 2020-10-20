using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Client
    {
        public string name { get; set; }
        public List<Contact> contacts { get; set; }

        public Client(string name, List<Contact> contacts)
        {
            this.name = name;
            this.contacts = contacts;
        }

        public Client(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
