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
        public Pizza() 
        {
            _name = "";
            _price = 0;
        }
        #endregion

        #region Properties
        public string Name 
        {
        get { return _name; } set { _name = value; }
        }
        public int Price
        {
            get { return _price; } set { _price = value; }
        } 
        #endregion
    }
}
