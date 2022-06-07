using Lab.Demo.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class BaseLogic
    {
        protected readonly NothwindContext context;

        public BaseLogic()
        {
            context = new NothwindContext();
        }

    }
}
