using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.EF.Datos;

namespace TP3.EF.Logic
{
    public class BaseLogic
    {
        protected readonly NortwhindContext context;

        public BaseLogic()
        {
            context = new NortwhindContext();
        }

        
    }
}
