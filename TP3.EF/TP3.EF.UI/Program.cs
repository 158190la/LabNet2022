using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.EF.Entities;
using TP3.EF.Logic;

namespace TP3.EF.UI
{
    internal class Program : ShippersLogic
    {
        static void Main(string[] args)
        {

            Menu();
            int opcion = int.Parse(Console.ReadLine());
            
            while (opcion != 5)
            {
                switch (opcion)
                {
                    case 1:

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
                        break;
                    case 2:

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



                        break;
                    case 3:
                        ShippersLogic shippersLogicdelete = new ShippersLogic();
                        Console.WriteLine("Ingrese el ID del Shipper a Eliminar");
                        int idAEliminar = int.Parse(Console.ReadLine());
                        shippersLogicdelete.Delete(idAEliminar);
                        
                        break;

                    case 4:
                        
                        Show();                                   
                        
                        break;

                       
                }
                Menu2();
                opcion = int.Parse(Console.ReadLine());
            }
            







           
            
        }
    }
}
