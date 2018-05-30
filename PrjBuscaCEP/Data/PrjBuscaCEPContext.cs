using PrjBuscaCEP.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PrjBuscaCEP.Data
{
    public class PrjBuscaCEPContext : DbContext
    {
        public PrjBuscaCEPContext() : base("PrjBuscaCEP_Dev"){}
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}