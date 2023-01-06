using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUC5
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

            //created addressBook list use to store 
            addressBook.Add(contact);

        }

        public void addPerson()
        {
            Contact newcontact = new Contact();

            Console.WriteLine("Enter First Name of Person :");
            newcontact.FirstName = Console.ReadLine();

            foreach (Contact contact in addressBook)
            {
                //ToLower() added which convert any String into lower case
                if (contact.FirstName.ToLower() == newcontact.FirstName.ToLower())
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

        public void EditContact()
        {
            Console.WriteLine("Please Enter Name of Person to Edit");
            string FirstName = Console.ReadLine();

            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName.ToLower() == FirstName.ToLower())
                {
                    Console.WriteLine("First Name Matches, please Enter Details to Edit ");
                    Console.WriteLine("Select options to Edit Details :\n" +
                        "1) Last Name\n" + "2) Address\n" + "3) City\n" +
                        "4) State\n" + "5) Zip Code\n" + "6) Phone Number\n" + "7) E-mail\n");

                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:

                            Console.WriteLine("Enter Last Name");
                            contact.LastName = Console.ReadLine();
                            break;

                        case 2:

                            Console.WriteLine("Enter Address");
                            contact.Address = Console.ReadLine();
                            break;

                        case 3:

                            Console.WriteLine("Enter City");
                            contact.City = Console.ReadLine();
                            break;

                        case 4:

                            Console.WriteLine("Enter State");
                            contact.State = Console.ReadLine();
                            break;

                        case 5:

                            Console.WriteLine("Enter Zip Code");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 6:

                            Console.WriteLine("Enter Phone Number");
                            contact.PhoneNo = Convert.ToInt64(Console.ReadLine());
                            break;

                        case 7:

                            Console.WriteLine("Enter E-mail");
                            contact.Email = Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Please Enter proper option");
                            break;

                    }

                }
                Console.WriteLine("No Contact Details found");
            }
        }

        public void DeleteContact()
        {
            Console.WriteLine("Please Enter Name of Person to Edit");
            string FirstName = Console.ReadLine();

            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName.ToLower() == FirstName.ToLower())
                {
                    addressBook.Remove(contact);
                    Console.WriteLine("Entered First Name is Deleted from the List");
                    return;
                }
            }
            Console.WriteLine("Contact not Found ");
        }

        public void AddMultipleContact()
        {
            Console.WriteLine("Enter Number of contact to Add");

            int Number = Convert.ToInt32(Console.ReadLine());
            //while loop is used to store contacts which user input as a number

            while (Number > 0)
            {

                addPerson();
                Console.WriteLine(":::::::::::::::::::::::::::;");
                Number--;
            }
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
