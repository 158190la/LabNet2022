using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.EF.Datos;
using TP3.EF.Entities;

namespace TP3.EF.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public void Add(Shippers newShippers)
        {
            context.Shippers.Add(newShippers);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ShipperAEliminar = context.Shippers.Find(id);
           
            context.Shippers.Remove(ShipperAEliminar);
            
            context.SaveChanges();
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Update(Shippers shippers)
        {
            var shipperUpdate = context.Shippers.Find(shippers.ShipperID);

            shipperUpdate.CompanyName = shippers.CompanyName;
            shipperUpdate.Phone=shippers.Phone;
            context.SaveChanges();
        }

        public static void Show()
        {
            ShippersLogic shipperlogic = new ShippersLogic();
            Console.WriteLine("ID - Company Name - Phone");
            foreach (Shippers shippers in shipperlogic.GetAll())
            {
                Console.WriteLine($"{shippers.ShipperID} -{shippers.CompanyName} - {shippers.Phone}");
            }
           
        }
        public static void Menu()
        {
            Console.WriteLine("Bienvenido al gestor de base de datos Nortwhind");
            Console.WriteLine("Opciones");
            Console.WriteLine("Seleccione en que tabla quiere trabajar");
            Console.WriteLine("1 - Agregar Registro");
            Console.WriteLine("2 - Modificar Registro");
            Console.WriteLine("3 - Eliminar Registro");
            Console.WriteLine("4 - Mostrar Tabla");
            Console.WriteLine("5 - Salir");
        }
        public static void Menu2()
        {
            
            Console.WriteLine("Opciones");
            Console.WriteLine("Seleccione en que tabla quiere trabajar");
            Console.WriteLine("1 - Agregar Registro");
            Console.WriteLine("2 - Modificar Registro");
            Console.WriteLine("3 - Eliminar Registro");
            Console.WriteLine("4 - Mostrar Tabla");
            Console.WriteLine("5 - Salir");
        }
    }
}
