using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //field
        //public string FirstName2; böyle bir tanımlamada mevcut

        //property
        public int Id { get; set; }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = "Mr." + value; }
        }
        public string LastName { get; set; } // auto property
        public string City { get; set; }
    }
}
