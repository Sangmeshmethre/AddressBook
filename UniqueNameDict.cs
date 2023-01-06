using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUC6
{
    public class UniqueNameDict
    {
        //Dictionary is used to store

        public Dictionary<string, AddressBook> addBookobj = new Dictionary<string, AddressBook>();
        public void NewAddressBook()
        {
            AddressBook newAddBook = new AddressBook();
            newAddBook.AddMultipleContact();

            Console.WriteLine("Please enter Name of the AddressBook:");
            string addName = Convert.ToString(Console.ReadLine());
            addBookobj.Add(addName.ToLower(), newAddBook);

        }
    }
}
