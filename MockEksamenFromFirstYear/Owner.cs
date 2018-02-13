using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamenFromFirstYear
{
    public class Owner
    {
        private string _address;
        private string _name;
        private string _phone;


        public Owner(string address, string name, string phone)
        {
            if (address.Length < 6)
            {
                throw new ArgumentException("Address skal have mere end 6 tegn ");
            }

            if (name.Length < 4)
            {
                throw new ArgumentException("Name skal have mere end 4 tegn");
            }

            if ((phone.Length < 8) || (phone.Length > 8))
            {
                throw new ArgumentException("Phone skal have 8 tegn");
            }
            _address = address;
            _name = name;
            _phone = phone;
        }

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

    }
   
}
