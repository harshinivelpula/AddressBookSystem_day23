using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem3
{
    internal class Collection
    {
        List<Contacts> contactList = new List<Contacts>();
        public void MultiCon()
        {
            for (int i = 0; i < 3; i++)
            {
                Contacts NewCon = new Contacts();

                Console.WriteLine("Enter Name");
                NewCon.Name = Console.ReadLine();
                Console.WriteLine("Enter Address");
                NewCon.Address = Console.ReadLine();
                Console.WriteLine("Enter City");
                NewCon.city = Console.ReadLine();
                Console.WriteLine("Enter State");
                NewCon.State = Console.ReadLine();
                Console.WriteLine("Enter Email");
                NewCon.email = Console.ReadLine();
                Console.WriteLine("Enter Zip");
                NewCon.Zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone");
                NewCon.phone = Convert.ToInt32(Console.ReadLine());
                contactList.Add(NewCon);
            }
            foreach (var con in contactList)
            {
                Console.WriteLine(con.Name);
                Console.WriteLine(con.Address);
                Console.WriteLine(con.city);
                Console.WriteLine(con.State);
                Console.WriteLine(con.email);
                Console.WriteLine(con.Zip);
                Console.WriteLine(con.phone);
                Console.WriteLine("*******************************************************************");

            }
            Console.WriteLine("*******************-----------------------------------------------------------------**************************");
        }

    }
}
