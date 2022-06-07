using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using TP3.EF.Entities;

namespace TP3.EF.Datos
{
    public partial class NortwhindContext : DbContext
    {
        public NortwhindContext()
            : base("name=NortwhindConnection")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
