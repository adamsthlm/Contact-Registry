﻿/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/


namespace Contact_Registry
{
    class Contact
    {
        // Fields
        private string _firstname = string.Empty;
        private string _lastname = string.Empty;
        
        // private Address _address = new Address(); * Varför ska jag inte ha ett _address fält?

        // Aggregation
        private Address address;

        // Properties
        public string Firstname { get; set; }

        private string lastname;

        public string GetLastname() { return lastname.ToUpper(); }

        public void SetLastname(string value) => lastname = value;
      

        public string Fullname
        {
            get { return Firstname + " " + ToUpper(GetLastname()); }
        }




        // default constructor
        public Contact() { address = new Address(); }

        // constructor w. 3 params.
        public Contact(string firstname, string lastname, Address adr)
        {
            _firstname = Firstname; // Field _firstname is set via property Firstname
            _lastname = GetLastname(); // Field _lastname is set via property Lastname
            this.address = adr; // one Address object
        }

        // theOther constructor for copying objects
        public Contact(Contact theOther)
        {
            _firstname = theOther._firstname;
            _lastname = theOther._lastname;
            this.address = new Address(theOther.address); // för att få denna rad att fungera skapade jag fält och konstruktor i klassen Address

        }

        public bool ValidateData()
        {

            bool ok = true;

            if (ok)
            {
                if (_firstname.Equals(string.Empty))
                {
                    ok = false;
                    return ok;
                } else

                if (_lastname.Equals(string.Empty))
                {
                    ok = false;
                    return ok;
                } else

                if (!address.Equals(this.address))
                {
                    ok = false;
                }
                return ok;
            }
            return ok;
        }

        public override string ToString()
        {
            string strOut = string.Format("{0,-20} {1}", Fullname, address.ToString());
            return strOut;
        }  

        private string ToUpper(string lastname)
        {
            string outString = lastname.ToUpper();
            return outString;
        }

    } // class 
}// namespace 
