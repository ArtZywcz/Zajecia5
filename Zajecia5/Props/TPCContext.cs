using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia5.Props
{
    class TPCContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<PC>().Map(map =>
            {
                map.MapInheritedProperties();
                map.ToTable("Stacjonarne");
            });

            modelBuilder.Entity<Laptop>().Map(map =>
            {
                map.MapInheritedProperties();
                map.ToTable("Przenośne");
            });
        }
    }
}
