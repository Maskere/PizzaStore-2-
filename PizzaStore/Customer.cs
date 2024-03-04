using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {
        #region Instance Field
        private string _name;
        private string _phoneNumber;
        private string _email;
        #endregion

        #region Constructor
        public Customer(string Name) 
        {
            _name = Name;
            _phoneNumber = PhoneNumber;
            _email = Email;
        }
        #endregion

        #region Properties
        public string Name
        { 
            get { return _name; }
            set { _name = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            private set { _phoneNumber = value; }
        }

        public string Email
        { 
            get { return _email; }
            private set { _email = value; }
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{Name}";
        }
        #endregion
    }
}
