using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductsLogic productsLogic = new ProductsLogic();

            //foreach (Products products in productsLogic.GetAll())
            //{
            //    Console.WriteLine($"{products.ProductName} - {products.UnitPrice} - {products.UnitsInStock}");
            //}
            
            RegionLogic regionLogic = new RegionLogic();

            foreach (var item in regionLogic.GetAll())
            {
                Console.WriteLine($"{item.RegionID}-{item.RegionDescription}");
            }
            Console.WriteLine();
            //regionLogic.Add(new Region
            //{
            //    RegionID = 10,
            //    RegionDescription = "holajc"
            //});
            //regionLogic.Delete(10);

            regionLogic.Update(new Region 
            { 
                RegionDescription = "nueva Descrirrsrasrasr",
                RegionID = 10
            });



            foreach (var item in regionLogic.GetAll())
            {
                Console.WriteLine($"{item.RegionID}-{item.RegionDescription}");
            }





            Console.ReadLine();



        }
    }
}
