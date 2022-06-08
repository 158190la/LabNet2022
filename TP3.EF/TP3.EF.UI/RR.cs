using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.EF.Entities;
using TP3.EF.Logic;

namespace TP3.EF.UI
{
    internal class ReadAndWrite
    {
        public static void AddShippers()
        {
            ShippersLogic shippersLogicadd = new ShippersLogic();
            Console.WriteLine("Ingrese el Nombre del nuevo Shipper");
            string newShipperName = Console.ReadLine();
            Console.WriteLine("Ingrese el Numero del nuevo Shipper");

            string newShipperTelephone = Console.ReadLine();
            shippersLogicadd.Add(new Shippers
            {
                CompanyName = newShipperName,
                Phone = newShipperTelephone
            });
        }

        public static void UpdateShippers()
        {
            ShippersLogic shippersLogicUpdate = new ShippersLogic();
            Console.WriteLine("Ingrese el ID del shipper a Modificar");
            int updateID = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Nombre del shipper a Modificar");
            string updateShipperName = Console.ReadLine();
            Console.WriteLine("Ingrese el Telefono del shipper a Modificar");
            string updateShipperPhone = Console.ReadLine();
            shippersLogicUpdate.Update(new Shippers
            {
                ShipperID = updateID,
                CompanyName = updateShipperName,
                Phone = updateShipperPhone

            });
        }

        public static void DeleteShippers()
        {
            ShippersLogic shippersLogicdelete = new ShippersLogic();
            Console.WriteLine("Ingrese el ID del Shipper a Eliminar");
            int idAEliminar = int.Parse(Console.ReadLine());
            shippersLogicdelete.Delete(idAEliminar);
        }
        public static void Menu()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Bienvenido al gestor de base de datos Nortwhind");
            Console.WriteLine("Opciones");
            Console.WriteLine("1 - Agregar Registro a Shippers");
            Console.WriteLine("2 - Modificar Registro de Shippers");
            Console.WriteLine("3 - Eliminar Registro de Shippers");
            Console.WriteLine("4 - Mostrar Tabla");
            Console.WriteLine("5 - Consulta Categories");
            Console.WriteLine("6 - Salir");
            Console.WriteLine("Ingrese su Opcion");
            Console.WriteLine("-----------------------------------------------");

        }
        public static void Menu2()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Opciones");
            Console.WriteLine("1 - Agregar Registro a Shippers");
            Console.WriteLine("2 - Modificar Registro de Shippers");
            Console.WriteLine("3 - Eliminar Registro de Shippers");
            Console.WriteLine("4 - Mostrar Tabla");
            Console.WriteLine("5 - Consulta Categories");
            Console.WriteLine("6 - Salir");
            Console.WriteLine("Ingrese su Opcion");
            Console.WriteLine("-----------------------------------------------");

        }


    }
}
