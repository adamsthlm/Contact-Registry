/*
Denna fil har skapats som en del av kursen [C# I] på Malmö University 2020
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
        private Countries _countries;
        
        // private Address _address = new Address(); * Varför ska jag inte ha ett _address fält?

        // Aggregation
        private Address address;

        // Properties or encapsulated fields - auto generated  (Ctrl-R
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public Countries Countries { get => _countries; set => _countries = value; }

        public string GetLastname() { return Lastname.ToUpper(); }



        public string Fullname
        {
            get { return Firstname + " " + ToUpper(GetLastname()); }
        }

     




        // default constructor
        public Contact() { address = new Address(); }

        // constructor w. 3 params.
        public Contact(string firstname, string lastname, Address adr)
        {
            Firstname = Firstname; // Field _firstname is set via property Firstname
            Lastname = lastname; // Field _lastname is set via property Lastname
            this.address = adr; // one Address object

        }
        // constructor w. 4 params.
        public Contact(string firstname, string lastname, Address adr, Countries country)
        {
            Firstname = Firstname; // Field _firstname is set via property Firstname
            Lastname = lastname; // Field _lastname is set via property Lastname
            this.address = adr; // one Address object
            Countries = Countries.EMPTY_NO_COUNTRY;
        }

        // theOther constructor for copying objects
        public Contact(Contact theOther)
        {
            Firstname = theOther.Firstname;
            Lastname = theOther.Lastname;
            this.address = new Address(theOther.address); // för att få denna rad att fungera skapade jag fält och konstruktor i klassen Address

        }

        public bool ValidateData()
        {

            bool ok = true;

            if (ok)
            {
                if (Firstname.Equals(string.Empty))
                {
                    ok = false;
                    return ok;
                } else

                if (Lastname.Equals(string.Empty))
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
