using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUC2
{
    public class AddressBook
    {
        //Ceating List to store contacts
        public List<Contact> addressBook = new List<Contact>();

        public void createContact()
        {
            //instance creating of Contact class

            Contact contact = new Contact();

            Console.WriteLine("1) Enter First Name :");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("2)Enter Last Name");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("3)Enter Address");
            contact.Address = Console.ReadLine();

            Console.WriteLine("4)Enter City Name");
            contact.City = Console.ReadLine();

            Console.WriteLine("5)Enter State");
            contact.State = Console.ReadLine();

            Console.WriteLine("6)Enter Zip Code");
            contact.Zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("7)Enter Phone Number");
            contact.PhoneNo = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("8)Enter Email-Id");
            contact.Email = Console.ReadLine();

            addressBook.Add(contact);

        }

        public void addPerson()
        {
            Contact newcontact = new Contact();

            Console.WriteLine("Enter First Name of Person :");
            newcontact.FirstName = Console.ReadLine();

            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName == newcontact.FirstName)
                {
                    Console.WriteLine("Person with this Name Already Exists");
                    return;
                }
            }
            Console.WriteLine("2)Enter Last Name");
            newcontact.LastName = Console.ReadLine();

            Console.WriteLine("3)Enter Address");
            newcontact.Address = Console.ReadLine();

            Console.WriteLine("4)Enter City Name");
            newcontact.City = Console.ReadLine();

            Console.WriteLine("5)Enter State");
            newcontact.State = Console.ReadLine();

            Console.WriteLine("6)Enter Zip Code");
            newcontact.Zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("7)Enter Phone Number");
            newcontact.PhoneNo = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("8)Enter Email-Id");
            newcontact.Email = Console.ReadLine();

            addressBook.Add(newcontact);
        }

        //Display method 
        public void Display()
        {
            foreach (Contact contact in addressBook)
            {
                Console.WriteLine(contact.FirstName);
                Console.WriteLine(contact.LastName);
                Console.WriteLine(contact.Address);
                Console.WriteLine(contact.City);
                Console.WriteLine(contact.State);
                Console.WriteLine(contact.Zip);
                Console.WriteLine(contact.PhoneNo);
                Console.WriteLine(contact.Email);
            }
        }
    }
}
