using System;
using System.Collections.Generic;


namespace Program
{   
    class Program
    {
        
        static void Main(string[] args)
        {
            Contact contact1 = new Contact("John Doe", "email", "as soon as available");
            Contact contact2 = new Contact("Jane Doe", "fax", "after 8 am");
            Contact contact3 = new Contact("Collect", "email", "between 8 and 8:30 am");
            List<Contact> contacts = new List<Contact>();
            contacts.Add(contact1);
            contacts.Add(contact2);
            contacts.Add(contact3);
            Client client1 = new Client("John Doe Medical Office", contacts);
            Schedule schedule = new Schedule();
            schedule.sendRaports(client1);
        }
    }
}
