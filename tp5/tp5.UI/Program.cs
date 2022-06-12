using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp5.Logic;

namespace tp5.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        
            CustomersLogic customersLogic = new CustomersLogic();
            var query = CustomersLogic.ObjetoCustomer();

            foreach (var item in query)
            {
                Console.WriteLine(item.ContactName);
                Console.ReadLine();
            }

            ProductsLogic productsLogic = new ProductsLogic();

            var query2 = ProductsLogic.UnitsInStock();

            foreach (var item in query2)
            {
                Console.WriteLine($" {item.ProductName} - {item.UnitsInStock}");
            }

            Console.ReadLine();

            var query3 = ProductsLogic.UnitsInStockMore3();

            foreach (var item in query2)
            {
                Console.WriteLine($" {item.ProductName} - {item.UnitsInStock} - {item.UnitPrice}");
            }

            Console.ReadLine();

            var query4 = CustomersLogic.CustomerRegion();

            foreach (var item in query4)
            {
                Console.WriteLine($" {item.ContactName} - {item.Region} ");
                
            }

            Console.ReadLine();

            var query6 = CustomersLogic.MinMayus();

            foreach (var item in query6)
            {
                Console.WriteLine($" {item.CompanyName.ToLower()}");
                Console.WriteLine($" {item.CompanyName.ToUpper()}");

            }

            Console.ReadLine();

            var query7 = CustomersLogic.CustomersOrders();

            foreach (var item in query7)
            {
                Console.WriteLine(item.ToString());
                

            }

            Console.ReadLine();

        }


    }
}
