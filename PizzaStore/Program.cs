using System;

namespace PizzaStore 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Customer customer = new Customer("");
            Pizza pizza = new Pizza("",0);
            Order order = new Order(customer, pizza, 0);
            BigMamma bigmamma = new BigMamma();
            bigmamma.Start();
            Console.WriteLine();
        }
    }
}