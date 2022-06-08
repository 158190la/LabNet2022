using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.EF.Datos;
using TP3.EF.Entities;

namespace TP3.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
       
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Add(Categories newCategories)
        {
            context.Categories.Add(newCategories);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var cateogireAEliminar = context.Categories.Find(id);

            context.Categories.Remove(cateogireAEliminar);

            context.SaveChanges();
        }

        public void Update(Categories categories)
        {
            var categoriesUpdate = context.Categories.Find(categories.CategoryID);

            categoriesUpdate.CategoryName = categories.CategoryName;

            context.SaveChanges();
        }
        public static void Show()
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            Console.WriteLine("ID - Name - Descripcion");
            foreach (Categories categories in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{categories.CategoryID} -{categories.CategoryName} - {categories.Description}");
            }

        }


    }
}
