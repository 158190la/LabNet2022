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

        //public static List<Products> ProductNull789()
        //{
        //    var _context = new NorthwindContext();

        //    var query = from Products in _context.Products
        //                where Products.ProductID == 789 && Products
        //                select Products;

        //    return query.ToList();
        //}


    }
}
