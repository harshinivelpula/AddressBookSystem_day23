using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem3
{
    public class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string State { get; set; }
        public string email { get; set; }
        public int Zip { get; set; }
        public int phone { get; set; }

    }
    public class AddressBook
    {
        

        public void Contact()
        {
            List<Contact> contactList = new List<Contact>();
            contactList.Add(new Contact
            {
                Name = "charu",
                Address = "India",
                city = "Chennai",
                State = "tml",
                email = "charu@gmail.com",
                Zip = 987654,
                phone = 987654321
            });
            contactList.Add(new Contact
            {
                Name = "chocky",
                Address = "india",
                city = "bihar",
                State = "br",
                email = "chocky@gmail.com",
                Zip = 876543,
                phone = 1225461458
            });
            contactList.Add(new Contact
            {
                Name = "haswika",
                Address = "india",
                city = "bengaluru",
                State = "krn",
                email = "haswika@gmail.com",
                Zip = 765432,
                phone = 1226187458
            });

            contactList.Add(new Contact
            {

                Name = "haswik",
                Address = "india",
                city = "mumbai",
                State = "mh",
                email = "haswik@gmail.com",
                Zip = 654321,
                phone = 12261568
            });
            foreach (var contacts in contactList)
            {
                Console.WriteLine(contacts.Name);
                Console.WriteLine(contacts.Address);
                Console.WriteLine(contacts.city);
                Console.WriteLine(contacts.State);
                Console.WriteLine(contacts.email);
                Console.WriteLine(contacts.Zip);
                Console.WriteLine(contacts.phone);
                Console.WriteLine("**************************");
            }

            Console.WriteLine("*******************-----------------------------------------------------------------**************************");
        }

        public void Add()
        {
            Contact createcontact = new Contact();

            Console.WriteLine("Enter Name");
            createcontact.Name = Console.ReadLine();
            Console.WriteLine("Enter Address");
            createcontact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            createcontact.city = Console.ReadLine();
            Console.WriteLine("Enter State");
            createcontact.State = Console.ReadLine();
            Console.WriteLine("Enter Email");
            createcontact.email = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            createcontact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone");
            createcontact.phone = Convert.ToInt32(Console.ReadLine());
           


        }
    }

}
