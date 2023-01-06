using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUC4
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
                    "2)Add new Contact, Display and Stores contact in the list\n" +
                    "3)Edit Details of Contact\n" +
                    "4)Remove Contact Details from the List\n");

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

                    case 3:

                        AddressBook addobj2 = new AddressBook();
                        Console.WriteLine("::::::::::::::::::::::::::");

                        bool check1 = true;

                        while (check1)
                        {
                            Console.WriteLine("Follow Steps to add details:\n" +
                               "1) To addContact\n" + "2) To Edit Contact\n" +
                               "3) To Display Contact\n");

                            int select = Convert.ToInt32(Console.ReadLine());
                            switch (select)
                            {
                                case 1:
                                    addobj2.addPerson();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 2:
                                    addobj2.EditContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 3:
                                    addobj2.Display();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                default:

                                    check = !check;
                                    break;
                            }
                        }
                        break;

                    case 4:

                        AddressBook addobj3 = new AddressBook();
                        Console.WriteLine("::::::::::::::::::::::::::");

                        bool check2 = true;

                        while (check2)
                        {
                            Console.WriteLine("Follow Steps to add details:\n" +
                               "1) To addContact\n" + "2) To Edit Contact\n" +
                               "3) To Remove Contact\n" + "4) To Display Contact\n");

                            int select = Convert.ToInt32(Console.ReadLine());
                            switch (select)
                            {
                                case 1:
                                    addobj3.addPerson();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 2:
                                    addobj3.EditContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 3:
                                    addobj3.DeleteContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 4:
                                    addobj3.Display();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;


                                default:

                                    check = !check;
                                    break;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Please select proper option");
                        break;
                }
                check = false;
                Console.WriteLine("Try Again ");
                break;
            }
        }
    }
}