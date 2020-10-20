using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Schedule
    {
        public void sendRaports(Client client)
        {
            Console.WriteLine("For " + client.name + ':');
            Console.WriteLine();
            foreach (Contact contact in client.contacts)
            {
                if (contact.deliveryHours.Equals("as soon as available"))
                {
                    sendRaport(contact);
                }
                else
                {
                    string[] words = contact.deliveryHours.Split(' ');
                    TimeSpan time = DateTime.Now.TimeOfDay;
                    if (words[0].Equals("after"))
                    {
                        //negleted minutes in hour verification 
                        if (words[1].CompareTo(time.Hours.ToString()) < 0)
                        {
                            sendRaport(contact);
                        }
                        else
                        {
                            scheduleSendRaport(contact);
                            // an email/fax/hl7 should be scheduled to be sent to the contact after the hour he set
                        }
                    }
                    if (words[0].Equals("between"))
                    {
                        //negleted minutes
                        if (words[1].CompareTo(time.Hours.ToString()) > 0 && words[3].CompareTo(time.Hours.ToString()) < 0)
                        {
                            sendRaport(contact);
                        }
                        else
                        {
                            scheduleSendRaport(contact);
                            // an email/fax/hl7 should be scheduled to be sent to the contact between the hours he set
                        }
                    }
                }
            }

            Console.ReadLine();

        }

        static void sendRaport(Contact contact)
        {
            Console.WriteLine(contact.delivery + " sent to " + contact.name);
        }

        static void scheduleSendRaport(Contact contact)
        {
            Console.WriteLine(contact.delivery + " will be sent to " + contact.name + ' ' + contact.deliveryHours);
        }
    }
}
