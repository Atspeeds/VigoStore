using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Infrastrure.EFCore.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Infrastrure.EFCore
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }


        #region EntityTable
        public DbSet<Product> products { get; set; }
        #endregion



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assambale=typeof(PorductMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assambale);

            base.OnModelCreating(modelBuilder);
        }


    }
}
