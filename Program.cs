using AddressBookSystem3;

Console.WriteLine("Welcome to Address Book Program");


AddressBook addressBook = new AddressBook();
addressBook.Contact();
addressBook.Add();
addressBook.Edit();
addressBook.Delete();
Collection collection = new Collection();
collection.MultiCon();
MultiAddressBook multi = new MultiAddressBook();
multi.AddBook("AddressBookOne");
multi.AddContact("AddressBookOne");
