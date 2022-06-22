using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TP3.EF.TP8.APIRQ.Models
{
    [Table("Shippers")]
    public class ShippersView
    {
        [Key]
        [Column("ShipperID")]
        public int ShipperID { get; set; }
        [Column("CompanyName")]
        public string CompanyName { get; set; }
        [Column("Phone")]
        public string Phone { get; set; }
    }
}