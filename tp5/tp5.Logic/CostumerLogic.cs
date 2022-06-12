using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using tp5.Entities;
using tp5.Data;

namespace tp5.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public void ObjetoCustomer()
        {
            var customerBuscado = 0;

            var query = from Customers in context.Customers
                        where Customers.CustomerID
                       
        }
    }
}
