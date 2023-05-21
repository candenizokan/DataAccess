using LinqToSql.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.Infastructure.SeedData
{
    internal class SeedAuthor : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData
                (
                    new Author { Id = 1, FirstName ="Ali",LastName="Yılmaz"},
                    new Author { Id = 2, FirstName ="Cevat",LastName="Fırtına"},
                    new Author { Id = 3, FirstName ="Ayşe",LastName="Kırmızı"},
                    new Author { Id = 4, FirstName ="Ömer",LastName="Seyfettin"},
                    new Author { Id = 5, FirstName ="Can",LastName="Yücel"},
                    new Author { Id = 6, FirstName ="Mehmet",LastName="Kaş"},
                    new Author { Id = 7, FirstName ="Hakan",LastName="Yaşar"},
                    new Author { Id = 8, FirstName ="Celal",LastName="Kaya"},
                    new Author { Id = 9, FirstName ="İpek",LastName="Bilgin"},
                    new Author { Id = 10, FirstName ="Ece",LastName="Biricik"}
                );
        }
    }
}
