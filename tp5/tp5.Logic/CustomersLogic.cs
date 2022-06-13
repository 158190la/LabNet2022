using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using tp5.Entities;
using tp5.Data;
using System.Collections;

namespace tp5.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public static List<Customers>  ObjetoCustomer()
        {
            var _context = new NorthwindContext();
            //var query2 = from Customers in _context.Customers
            //            where Customers.CustomerID == "ALFKI"
            //            select Customers;

            var query = _context.Customers.Where(a => a.CustomerID == "ALFKI");           
            return query.ToList();
        }

        public static List<Customers> CustomerRegion()
        {
            var _context = new NorthwindContext();
            var query = (from Customers in _context.Customers
                         where Customers.Region == "WA"
                         select Customers)                         ;

            //var query3 = _context.Customers.Where(a => a.Region == "WA");
            return query.ToList();
        }

        public static List<Customers> MinMayus()
        {
            var _context = new NorthwindContext();
            var query = from Customers in _context.Customers
                         select Customers;

            return query.ToList();
        }
        //7. Query para devolver Join entre Customers y Orders donde los customers sean de la 
        // Región WA y la fecha de orden sea mayor a 1/1/1997.

        public static List<CustomerOrders> GetCustomersOrders()
        {
            var _context = new NorthwindContext();
            DateTime comparisonDate = new DateTime(1997, 1, 1);

            var query3 = from Customers in _context.Customers
                         join Orders in _context.Orders
                         on Customers.CustomerID equals Orders.CustomerID
                         where Orders.OrderDate > comparisonDate && Customers.Region == "WA"
                         select new CustomerOrders { CustomerID = Customers.CustomerID, OrderDate = Orders.OrderDate, Region = Customers.Region } ;

                       
            return query3.ToList();
        }
        public static List<CustomerOrders> CustomerOrdersAsociated()
        {
            var _context = new NorthwindContext();


            var query13 = from Customers in _context.Customers
                          join Orders in _context.Orders
                          on Customers.CustomerID equals Orders.CustomerID
                          group Customers by Customers.CustomerID into CustomersOrdersCount
                          select new CustomerOrders { Count = CustomersOrdersCount.Count(), CustomerID = CustomersOrdersCount.Key };
                          
                          


            return query13.ToList();
        }
        public static List<Customers> CustomerRegionTop3()
        {
            var _context = new NorthwindContext();
            var query2 = (from Customers in _context.Customers
                          where Customers.Region == "WA"
                          select Customers).Take(3);

            var query22 = _context.Customers
                                    .Where(r => r.Region == "WA")
                                    .Take(3);
            
            return query22.ToList();
        }
        

    }

}

