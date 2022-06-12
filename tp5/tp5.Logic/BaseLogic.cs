using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp5.Data;

namespace tp5.Logic
{   
        public class BaseLogic
        {
            protected readonly NorthwindContext context;

            public BaseLogic()
            {
                context = new NorthwindContext();
            }
        }
}
