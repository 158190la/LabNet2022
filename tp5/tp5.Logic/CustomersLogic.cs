using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using tp5.Entities;
using tp5.Data;

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

            var query3 = _context.Customers.Where(a => a.CustomerID == "ALFKI");           
            return query3.ToList();
        }

        public static List<Customers> CustomerRegion()
        {
            var _context = new NorthwindContext();
            var query2 = from Customers in _context.Customers
                         where Customers.Region == "WA"
                         select Customers;

            var query3 = _context.Customers.Where(a => a.Region == "WA");
            return query3.ToList();
        }

        public static List<Customers> MinMayus()
        {
            var _context = new NorthwindContext();
            var query3 = from Customers in _context.Customers
                         select Customers;

            return query3.ToList();
        }
        //7. Query para devolver Join entre Customers y Orders donde los customers sean de la 
        // Región WA y la fecha de orden sea mayor a 1/1/1997.

        public static List<Customers> CustomersOrders()
        {
            var _context = new NorthwindContext();
            DateTime comparisonDate = new DateTime(1997, 1, 1);
            var query3 = from Customers in _context.Customers
                         join Orders in _context.Orders
                         on Customers.CustomerID equals Orders.CustomerID
                         where Orders.OrderDate > comparisonDate && Customers.Region == "WA"
                         select Customers;

            var query4 = _context.Customers.Join(_context.Orders
                                    , c => c.CustomerID
                                    , m => m.CustomerID
                                    , (c, m) => new
                                    {
                                        c.CustomerID,
                                    });

            return query3.ToList();
        }

    }

}
//        public static void Show()
//        {
//            ShippersLogic shipperlogic = new ShippersLogic();
//            Console.WriteLine("ID - Company Name - Phone");
//            foreach (Shippers shippers in shipperlogic.GetAll())
//            {
//                Console.WriteLine($"{shippers.ShipperID} -{shippers.CompanyName} - {shippers.Phone}");
//            }
//
