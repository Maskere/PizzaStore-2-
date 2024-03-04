using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class BigMamma
    {
        #region Instance Field
        private Order _order;
        private Customer _customerName;
        private Pizza _pizzaName;
        private int _numberOfPizzasInOrder;
        private int _orderID;
        #endregion

        #region Constructor
        public BigMamma()
        {
            _orderID = OrderID;
            _order = new Order(CustomerName,PizzaName,NumberOfPizzasInOrder);;
            _customerName = new Customer("");
            _pizzaName = new Pizza("",0);
            _numberOfPizzasInOrder = NumberOfPizzasInOrder;
        }
        #endregion

        #region Properties
        public Order Order
        {
            get { return _order; }
        }
        public Customer CustomerName
        { 
            get { return _customerName; }
        }
        public Pizza PizzaName
        {
            get { return _pizzaName; }
        }
        public int NumberOfPizzasInOrder 
        {
            get { return _numberOfPizzasInOrder; }
        }
        public int OrderID
        { 
            get { return _orderID; }
            set { _orderID = value; }
        }
        #endregion
        public void Start()
        {
            Customer customer1 = new Customer("Miki");
            Pizza pizza1 = new Pizza("Vesuvio",100);
            Order Order1 = new Order(customer1, pizza1,1);
            Order1.CalculateTotalPrice();
            Console.WriteLine(Order1);

            Customer customer2 = new Customer("Lucas");
            Pizza pizza2 = new Pizza("Calzone", 100);
            Order Order2 = new Order(customer2,pizza2,1);
            Order2.CalculateTotalPrice();
            Console.WriteLine(Order2);

            Customer customer3 = new Customer("Jais");
            Pizza pizza3 = new Pizza("Tonno", 100);
            Order Order3 = new Order(customer3,pizza3,5);
            Order3.CalculateTotalPrice();
            Console.WriteLine(Order3);
        }
        public override string ToString() 
        {
            return $"";
        }
    }
}
