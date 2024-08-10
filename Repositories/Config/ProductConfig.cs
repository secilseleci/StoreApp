using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config;

public class ProductConfig : IEntityTypeConfiguration<Product>
{

    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.ProductId);
        builder.Property(p => p.ProductName).IsRequired();
        builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
        builder.HasData(
        new Product() { ProductId = 1, CategoryId = 2, ProductName = "Computer", ImageUrl = "/images/1.jpeg", Price = 17_000, ShowCase = true },
        new Product() { ProductId = 2, CategoryId = 2, ProductName = "Keyboard", ImageUrl = "/images/2.jpg", Price = 1_000 },
        new Product() { ProductId = 3, CategoryId = 2, ProductName = "Mouse", ImageUrl = "/images/3.webp", Price = 700 },
        new Product() { ProductId = 4, CategoryId = 2, ProductName = "Monitor", ImageUrl = "/images/4.webp", Price = 19_000 },
        new Product() { ProductId = 5, CategoryId = 2, ProductName = "Deck", ImageUrl = "/images/5.jpg", Price = 19_000 },
        new Product() { ProductId = 6, CategoryId = 1, ProductName = "Katip Bartleby", ImageUrl = "/images/6.png", Price = 50 },
        new Product() { ProductId = 7, CategoryId = 1, ProductName = "Hamlet", ImageUrl = "/images/7.jpg", Price = 70,ShowCase = true  },
        new Product() { ProductId = 8, CategoryId = 1, ProductName = "Goriot Baba", ImageUrl = "/images/8.png", Price = 60 ,ShowCase = true },
        new Product() { ProductId = 9, CategoryId = 1, ProductName = "Muhteşem Godisar", ImageUrl = "/images/9.jpeg", Price = 90 },
        new Product() { ProductId = 10, CategoryId = 1, ProductName = "Altıncı Koğuş", ImageUrl = "/images/10.png", Price = 123,ShowCase = true  },
        new Product() { ProductId = 11, CategoryId = 1, ProductName = "Spiderman", ImageUrl = "/images/11.jpg", Price = 99,ShowCase = true  }

        );
    }
}