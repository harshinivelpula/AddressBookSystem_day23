using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem3
{
    internal class MultiAddressBook
    {
        static Dictionary<string, AddressBook> multiaddresses = new Dictionary<string, AddressBook>();



        public void AddBook(string BookName)
        {
            Console.WriteLine("Add Book");
            string Bookname = Console.ReadLine();
            AddressBook Book;
            if (!multiaddresses.ContainsKey(Bookname))
            {
                multiaddresses.Add(Bookname, new AddressBook());
            }
        }
        public void AddContact(string BookName)
        {
            AddressBook book;
            if (!multiaddresses.ContainsKey(BookName))
            {
                book = new AddressBook();
            }
            else
            {
                book = multiaddresses[BookName];

            }
            book.Add();
            multiaddresses[BookName] = book;

        }
    }
}
