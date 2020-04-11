/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/


namespace Contact_Registry
{
    class Address
    {
        // fields
        private string _city = string.Empty;
        private Countries _country = Countries.EMPTY_NO_COUNTRY;
        private string _street = string.Empty;
        private string _zipCode = string.Empty;
        private string city = string.Empty;

        // properties
        public string City { get => city; set => city = value; }
        public Countries Country { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        // default constructor
        public Address() { }

        // constructor 3 parameters
        public Address(string street, string zipCode, string city)
        {
            _street = Street; // question: capital S in Street or lowercase s in street? 
            _zipCode = ZipCode; // and why??
            _city = City;
        }

        // constructor 4 parameters
        public Address(string street, string zipCode, string city, Countries country)
        {
            _street = Street;
            _zipCode = ZipCode;
            _city = City;
            _country = Country;
        }
    } // class 
} // namespace