using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO01
{
    public abstract class Animal
    {
        public int cantidadPatas { get; set; }

        public Animal (int cantidadPatas)
        {
            this.cantidadPatas = cantidadPatas;
        }

        public abstract string Caminar();
        
        public abstract string Descripcion();
        
    }
}
