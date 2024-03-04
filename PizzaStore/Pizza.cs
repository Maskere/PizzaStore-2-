using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        #region Instance Field
        private string _name;
        private int _price;
        #endregion

        #region Constructor
        public Pizza(string Name, int Price) 
        {
            _name = Name;
            _price = Price;
        }
        #endregion

        #region Properties
        public string Name 
        {
            get { return _name; } 
        }
        public double Price
        {
            get { return _price; } 
        }
        #endregion
        public override string ToString()
        {
            return $"{Name} - Price:{Price}";
        }
        
    }
}
