using Bakery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bakery.Data.Configurations 
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product> 
    {
        // Configurations of Product are defined in this method.
        public void Configure(EntityTypeBuilder<Product> builder) {
            // ImageName property is mapped to a column named "ImageFileName".
            builder.Property(p => p.ImageName).HasColumnName("ImageFileName");
        }
    }
}