using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUC2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            bool check = true;

            while (check)
            {
                Console.WriteLine("Please select the Options :\n" +
                    "1)Enter Details to add Contact in List\n" +
                    "2)Add new Contact, Display and Stores contact in the list\n");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        AddressBook addobj = new AddressBook();
                        Console.WriteLine("::::::::::::::::::::::::::");
                        addobj.createContact();
                        break;

                    case 2:

                        AddressBook addobj1 = new AddressBook();
                        Console.WriteLine("::::::::::::::::::::::::::");
                        addobj1.createContact();
                        Console.WriteLine("::::::::::::::::::::::::::");
                        Console.WriteLine("Entered Details of Person given as :");
                        addobj1.Display();
                        addobj1.addPerson();
                        break;


                    default:
                        Console.WriteLine("Please select proper option");
                        break;
                }
                check = false;
                break;
            }
        }
    }
}