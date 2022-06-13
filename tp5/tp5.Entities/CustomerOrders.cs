using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5.Entities
{
    public partial class CustomerOrders
    {
        [Key]
        [StringLength(5)]
        public string CustomerID { get; set; }

        [StringLength(15)]
        public string Region { get; set; }

        public DateTime? OrderDate { get; set; }

        public int OrderID { get; set; }

        public int Count { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }
    }
}
