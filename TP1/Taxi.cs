using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros) : base(pasajeros)
        {

        }
        public override string Avanzar()
        {
            return string.Format("En este taxi viajan {0} pasajeros", Pasajeros);
        }

        public override string Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
