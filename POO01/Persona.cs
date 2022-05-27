using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO01
{
    public class Persona : Animal
    {
        public Persona (int cantidadPatas) : base(cantidadPatas)
        {

        }
        public override string Caminar()
        {
            return $"Yo avanzo en {cantidadPatas} patas";
        }

        public override string Descripcion()
        {
            throw new NotImplementedException();
        }
    }
}
