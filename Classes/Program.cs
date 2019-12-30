using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            // set kısmı çalışır
            customer1.Id = 1;
            customer1.FirstName = "Arif";
            customer1.LastName = "Tarpıcı";
            customer1.City = "Ankara";

            Customer customer2 = new Customer
            {
                Id=2,FirstName="Arif2",LastName="Tarpıcı2",City="İstanbul"
            };
            Console.WriteLine(customer2.FirstName); // get kısmı çalışır
            Console.ReadLine();
        }
    }
}
