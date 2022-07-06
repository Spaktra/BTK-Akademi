using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager(); 
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.ID = 1;
            customer.FirstName = "Ahmet";
            customer.LastName = "Altay";

            Customer customer2 = new Customer 
            {
                ID = 2,
                City = "Ankara",
                FirstName = "Eren",
                LastName = "Altay",
            };

            Console.WriteLine(customer2.FirstName);
            Console.ReadKey();
        }
    }
}
