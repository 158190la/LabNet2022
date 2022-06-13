using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp5.Logic;
using tp5.Entities;
using System.Linq.Expressions;

namespace tp5.UI
{
    internal class ReadAndWrite
    {
        
        public static void Exc1()
        {   
            CustomersLogic customersLogic = new CustomersLogic();
            var query = CustomersLogic.ObjetoCustomer();

            foreach (var item in query)
            {
                Console.WriteLine(item.ContactName);

            }
            Console.ReadLine();
            Console.Clear();

        }

        public static void Exc2()
        {
            ProductsLogic productsLogic = new ProductsLogic();

            var query2 = ProductsLogic.UnitsInStock();

            foreach (var item in query2)
            {
                Console.WriteLine($" {item.ProductName} - {item.UnitsInStock}");
            }
            Console.ReadLine();
            Console.Clear();

        }

        public static void Exc3()
        {
            var query3 = ProductsLogic.UnitsInStockMore3();

            foreach (var item in query3)
            {
                Console.WriteLine($" {item.ProductName} - {item.UnitsInStock} - {item.UnitPrice}");
            }

            Console.ReadLine();
            Console.Clear();
        }
        public static void Exc4()
        {
            var query4 = CustomersLogic.CustomerRegion();

            foreach (var item in query4)
            {
                Console.WriteLine($" {item.ContactName} - {item.Region} ");
            }

            Console.ReadLine();
            Console.Clear();

        }

        public static void Exc5()
        {
            var query5 = ProductsLogic.FirstProductor789();

            
            Console.WriteLine($"{query5}");

            Console.ReadLine();
            Console.Clear();

        }

        public static void Exc6()
        {
            var query6 = CustomersLogic.MinMayus();

            foreach (var item in query6)
            {
                Console.WriteLine($" {item.CompanyName.ToLower()}");
                Console.WriteLine($" {item.CompanyName.ToUpper()}");
            }

            Console.ReadLine();
            Console.Clear();


        }

        public static void Exc7()
        {
            var query7 =CustomersLogic.GetCustomersOrders();


            foreach (CustomerOrders item in query7)
            {
                Console.WriteLine($"{item.CustomerID} - {item.OrderDate} - {item.Region}");   
            }
            
            Console.ReadLine();
            Console.Clear();


        }

        public static void Exc8()
        {
            var query8 = CustomersLogic.CustomerRegionTop3();

            foreach (var item in query8)
            {
                Console.WriteLine($" {item.ContactName} - {item.Region} ");
            }

            Console.ReadLine();
            Console.Clear();

        }

        public static void Exc9()
        {
            var query9 = ProductsLogic.ProductList();

            foreach (var item in query9)
            {
                Console.WriteLine($" {item.ProductName}");
            }

            Console.ReadLine();
            Console.Clear();

        }

        public static void Exc10()
        {
            var query10 = ProductsLogic.ProductListOrderStock();

            foreach (var item in query10)
            {
                Console.WriteLine($" {item.ProductName} - {item.UnitsInStock}");
            }

            Console.ReadLine();
            Console.Clear();

        }

        public static void Exc11()
        {
            var query11 = CategoriesLogic.CatProdcuts();

            foreach (var item in query11)
            {
                Console.WriteLine($" {item.CategoryID} - {item.CategoryName}");
            }

            Console.ReadLine();
            Console.Clear();


        }
        public static void Exc12()
        {
            var query12 = ProductsLogic.FirstProduct();

            foreach (var item in query12)
            {
                Console.WriteLine($" {item.ProductName}");
            }

            Console.ReadLine();
            Console.Clear();

        }

        public static void Exc13()
        {
            var query13 = CustomersLogic.CustomerOrdersAsociated();

            foreach (var item in query13)
            {
                Console.WriteLine($"{item.CustomerID} - {item.Count}");
            }

            Console.ReadLine();
            Console.Clear();

        }
    }        
}
