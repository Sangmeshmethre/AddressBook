using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUC1
{
    public class AddressBook
    {
        public void createContact()
        {
            Console.WriteLine("1) Enter First Name :");
            string FirstName = Console.ReadLine();

            Console.WriteLine("2)Enter Last Name");
            string LastName = Console.ReadLine();

            Console.WriteLine("3)Enter Address");
            string Address = Console.ReadLine();

            Console.WriteLine("4)Enter City Name");
            string City = Console.ReadLine();

            Console.WriteLine("5)Enter State");
            string State = Console.ReadLine();

            Console.WriteLine("6)Enter Zip Code");
            int Zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("7)Enter Phone Number");
            long PhoneN0 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("8)Enter Email-Id");
            string Email = Console.ReadLine();
        }
    }
}
