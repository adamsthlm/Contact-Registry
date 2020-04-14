/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/
using System.Collections.Generic;

namespace Contact_Registry
{
    class ContactManager
    {
        /// <summary>
        /// Create a list object called ContactList
        /// </summary>
        List<Contact> ContactList = new List<Contact>();

        // default constructor use a list of contacts
        public ContactManager()
        {
            ContactList = new List<Contact>();
        }


        public Contact GetContact(int index)
        {
            if (index < 0 || index >= ContactList.Count)
            {
                return null;
            }
            Contact origObj = ContactList[index];    // this just blew my mind!
            Contact copyObj = new Contact(origObj);  // and this!
            return copyObj;                          // spit out the copy
        }

        /// <summary>
        /// First check if parameters given is not null or empty then adds a contact to the list if list is +1 the return OK
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="addressIN"></param>
        /// <returns> true if list is 1 post longer else false and false if parameters not OK </returns>

        public bool AddContact(string firstName, string lastName, Address addressIN)
        {

            bool ok = true;
            int listLengt = ContactList.Count;
            if (CheckIfNamesIsValid(firstName, lastName, addressIN))
            {
                ContactList.Add(new Contact(firstName, lastName, addressIN));
                if (listLengt.Equals(listLengt + 1))
                {
                    ok = true;
                }
                return ok;
            }
            else
                return false;
        }

        // Re-factored by Visual Studio (Ctrl + R, M)
        private static bool CheckIfNamesIsValid(string firstName, string lastName, Address addressIN)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || addressIN == null)
            {
                return false;
            }
            else return true;
        }

        // Testvalues 
        public void TestValues()
        {
            AddContact("Apu", "Simpsson", new Address("Simpsson North Avenue", "123 45", "Johanneshov", Countries.Sverige));

        }


    } // class
} // namespace 

