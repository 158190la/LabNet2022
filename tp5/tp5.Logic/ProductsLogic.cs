using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp5.Data;
using tp5.Entities;

namespace tp5.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }
        public static List<Products> UnitsInStock()
        {
            var _context = new NorthwindContext();

            var query = from Products in _context.Products
                        where Products.UnitsInStock > 0
                        select Products;

            var query2 = _context.Products
                                     .Where(p => p.UnitsInStock > 0);

            return query.ToList();
        }

        public static List<Products> UnitsInStockMore3()
        {
            var _context = new NorthwindContext();

            var query = from Products in _context.Products
                        where Products.UnitsInStock > 0 && Products.UnitPrice > 3
                        select Products;

            return query.ToList();
        }

        public static List<Products> ProductList()
        {
            var _context = new NorthwindContext();

            var query = from Products in _context.Products
                        orderby Products.ProductName
                        select Products;

            var query2 = _context.Products
                                    .OrderBy(r => r.ProductName);

            return query.ToList();
        }

        public static List<Products> ProductListOrderStock()
        {
            var _context = new NorthwindContext();

            var query = from Products in _context.Products
                        orderby Products.UnitsInStock descending
                        select Products;

            var query2 = _context.Products
                                    .OrderByDescending(x => x.UnitsInStock);
            return query.ToList();
        }

        public static List<Products> FirstProduct()
        {
            var _context = new NorthwindContext();

            var query = (from Products in _context.Products
                         orderby Products.UnitsInStock
                         select Products).Take(1);

            var query2 = _context.Products
                                    .OrderBy(r => r.UnitsInStock)
                                    .Take(1);

            return query2.ToList();
        }



        public static Products FirstProductor789()
        {
            var _context = new NorthwindContext();
            var query = _context.Products
                                    .FirstOrDefault(p => p.ProductID == 789);

            return query;

        }


    }
}
