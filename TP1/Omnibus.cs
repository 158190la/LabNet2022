using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros) : base(pasajeros)
        {

        }
        public override string Avanzar()
        {
            return string.Format("En este omnibus viajan {0} pasajeros", Pasajeros);
        }

        public override string Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
