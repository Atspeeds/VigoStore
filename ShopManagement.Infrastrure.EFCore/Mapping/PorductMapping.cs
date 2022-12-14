using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Infrastrure.EFCore.Mapping
{
    public class PorductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Code).HasMaxLength(15).IsRequired();
            builder.Property(x => x.ShortDescription).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Picture).HasMaxLength(1000);
            builder.Property(x => x.PictureAlt).HasMaxLength(255);
            builder.Property(x => x.PictureTitle).HasMaxLength(500);

            builder.Property(x => x.KeyWords).HasMaxLength(100).IsRequired();
            builder.Property(x => x.MetaDescription).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(500).IsRequired();



            #region SeedDataSql
            builder.HasData(new Product("#tes", "TES1", "firsTest", "this is test"
                , 2300, "test.jpg", "tests",
                "titletest", "test", "testtest", "testslug"));
            #endregion

            //Relation Ship

            //Products ---> ProductCategory
            //builder.HasOne(x => x.Category)
            //    .WithMany(x => x.Products)
            //    .HasForeignKey(x => x.CategoryId);
        }
    }
}
