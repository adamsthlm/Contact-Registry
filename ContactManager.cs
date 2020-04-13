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
        /// Adds a contact to the list
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="addressIN"></param>
        /// <returns> True if list is 1 post longer else false </returns>
        
        public bool AddContact(string firstName, string lastName, Address addressIN)
        {
            
            // variables
            bool ok = true;
            int listLengt = ContactList.Count;

            // The logic
            if (ok)
            {
                ContactList.Add(new Contact(firstName, lastName, addressIN));
                if (listLengt.Equals(listLengt + 1))
                {
                    ok = true;
                }
                return ok;
            }else
                return false;
        }

    } // class
} // namespace 

