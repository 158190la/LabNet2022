using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp5.Data;
using tp5.Entities;

namespace tp5.Logic
{

    public class CategoriesLogic : BaseLogic
    {

        public static List<Categories> CatProdcuts()
        {
            var _context = new NorthwindContext();

            var query = from Categories in _context.Categories
                        select Categories;

            return query.ToList();

        }
            

    }
}
