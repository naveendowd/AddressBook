using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_AddressbookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program!");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact();
            addressBook.DisplayContact();
            //addressBook.EditContact();
            //addressBook.DisplayContact();
            addressBook.DeleteContact();
            addressBook.DisplayContact();
        }
    }
}