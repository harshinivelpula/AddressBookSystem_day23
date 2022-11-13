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
    public void Edit()
    {
        Console.WriteLine("Enter The Name to Edit The Contact");
        string Name = Console.ReadLine();
        
        foreach (var conts in contactList)
        {
            if (conts.Name == Name)
            {


                // Taking Input by User Which Field want to Edit 
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Address");
                Console.WriteLine("3. City");
                Console.WriteLine("4. state");
                Console.WriteLine("5. Email Address");
                Console.WriteLine("6. Zip Code ");
                Console.WriteLine("7. Phone Number ");

                Console.WriteLine("Enter the Field number you Want to Edit ");
                int Choice = Convert.ToInt32(Console.ReadLine());

                // using Switch to Edit The Field Choose By User
                switch (Choice)
                {
                    case 1:
                        Console.Write("New First Name : ");
                        string New_Name = Console.ReadLine();
                        conts.Name = New_Name;
                        break;

                    case 2:
                        Console.Write("New Address : ");
                        string New_Address = Console.ReadLine();
                        conts.Address = New_Address;
                        break;
                    case 3:
                        Console.Write("New City : ");
                        string New_City = Console.ReadLine();
                        conts.city = New_City;
                        break;
                    case 4:
                        Console.Write("New State : ");
                        string New_State = Console.ReadLine();
                        conts.State = New_State;
                        break;
                    case 5:
                        Console.Write("New Email Address : ");
                        string New_Email_Address = Console.ReadLine();
                        conts.email = New_Email_Address;
                        break;
                    case 6:
                        Console.Write("New Zip Code : ");
                        int New_Zip_Code = Convert.ToInt32(Console.ReadLine());
                        conts.Zip = New_Zip_Code;
                        break;
                    case 7:
                        Console.Write("New Phone Number : ");
                        int New_Phone_Number = Convert.ToInt32(Console.ReadLine());
                        conts.phone = New_Phone_Number;
                        break;

                    default:
                        Console.WriteLine(" Please Enter Correct Choice");
                        break;
                }

            }
            else
            {
                Console.WriteLine(" Your Input Didn't Match the List of Contacts");
            }
        }
        
        foreach (var cont in contactList)
        {
            Console.WriteLine(cont.Name);
            Console.WriteLine(cont.Address);
            Console.WriteLine(cont.city);
            Console.WriteLine(cont.State);
            Console.WriteLine(cont.email);
            Console.WriteLine(cont.Zip);
            Console.WriteLine(cont.phone);
            Console.WriteLine("*******************************************************************");

        }
    }
}

}
