﻿using System;
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
        public static AddressBookMain BookName(Dictionary<string, AddressBookMain> addBook)
        {
            addressBook = addBook;
            Console.WriteLine("Enter address book name:");
            string name = Console.ReadLine();
            AddressBookMain address = addressBook[name];
            return address;
        }
        public static void DisplayPerson(Dictionary<string, AddressBookMain> addressDictionary)
        {
            List<Contacts> list = null;
            Console.WriteLine("Enter City or State name");
            string name = Console.ReadLine();
            foreach (var data in addressDictionary)
            {
                AddressBookMain address = data.Value;
                list = address.contactList.FindAll(x => x.city.Equals(name) || x.state.Equals(name));
                if (list.Count > 0)
                {
                    DisplayList(list);
                }
            }
            if (list == null)
            {
                Console.WriteLine("No person present in the address book with same city or state name");
            }
        }
        public static void DisplayList(List<Contacts> list)
        {
            foreach (var data in list)
            {
                data.Display();
            }
        }
    }
}
