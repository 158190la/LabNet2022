using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP3.EF.MVC.Models
{
    public class ShippersView
    {
        public int ShipperID { get; set; }

        public string CompanyName { get; set; }

        public string Phone { get; set; }
    }

    public class EditShippersView
    {
        public int ShipperID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }
        [StringLength(24)]
        [Phone]
        public string Phone { get; set; }
    }
}