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
        /// display the person details by city or state
        public static void PrintList(Dictionary<string, List<Contacts>> dictionary)
        {
            foreach (var data in dictionary)
            {
                Console.WriteLine("Details of person in {0}", data.Key);
                foreach (var person in data.Value)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", person.firstName, person.lastName, person.address,
                                                                   person.city, person.state, person.zipCode, person.phoneNumber, person.email);
                }
                Console.WriteLine("-----------------------------");
            }
        }
        /// count number of person by city or state
        public static void CountPerson(Dictionary<string, List<Contacts>> dictionary)
        {
            foreach (var person in dictionary)
            {
                Console.WriteLine("Number of person {0}:", person.Value.Count);
            }
        }
    }
}
