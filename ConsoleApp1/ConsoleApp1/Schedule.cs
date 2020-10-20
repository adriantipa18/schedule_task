using System;
using System.Collections.Generic;


namespace ConsoleApp1
{   
    class Schedule
    {
        static void sendRaports( Client client )
        {
            Console.WriteLine(client.name);
            foreach (Contact contact in client.contacts)
            {
                if (contact.deliveryHours.Equals("as soon as available"))
                    Console.WriteLine(contact.delivery + " sent to " + contact.name);
                else
                {
                    string[] words = contact.deliveryHours.Split(' ');
                    TimeSpan time = DateTime.Now.TimeOfDay;
                    if (words[0].Equals("after"))
                    {
                        //negleted minutes in hour verification 
                           if ( words[1].CompareTo(time.Hours.ToString()) < 0)
                            {
                                Console.WriteLine(contact.delivery + " sent to " + contact.name);
                            }
                           else
                            {
                                Console.WriteLine(contact.delivery + " will be sent to " + contact.name + ' ' + contact.deliveryHours);
                            // an email/fax/hl7 should be scheduled to be sent to the contact after the hour he set
                            }
                    }
                    if (words[0].Equals("between"))
                    {
                            //negleted minutes
                           if ( words[1].CompareTo(time.Hours.ToString()) > 0 && words[3].CompareTo(time.Hours.ToString()) < 0)
                            {
                                Console.WriteLine(contact.delivery + " sent to " + contact.name);
                            }
                           else
                            {
                            Console.WriteLine(contact.delivery + " will be sent to " + contact.name + ' ' + contact.deliveryHours);
                            // an email/fax/hl7 should be scheduled to be sent to the contact between the hours he set
                        }
                    }
                }
            }
                
                Console.ReadLine();

        }
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
            sendRaports(client1);
        }
    }
}
