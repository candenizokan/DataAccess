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
    internal class SeedBook : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
                (
                    new Book { Id = 1, Title = "Ali bananın çiftliği",GendreId="kor",Price=12.44 },
                    new Book { Id = 2, Title = "Uçurtma Avcisi",GendreId="psk",Price=888 },
                    new Book { Id = 3, Title = "Susma Sanatı",GendreId="kor",Price=34.45 },
                    new Book { Id = 4, Title = "Siyah Lale",GendreId="psk",Price=12.12 },
                    new Book { Id = 5, Title = "Körlük",GendreId="blm",Price=244 },
                    new Book { Id = 6, Title = "Satranç",GendreId="kor",Price=56.678 },
                    new Book { Id = 7, Title = "Suç ve Ceza",GendreId="mcr",Price=88 },
                    new Book { Id = 8, Title = "Yaprak Dökümü",GendreId="mcr",Price=367 },
                    new Book { Id = 9, Title = "Uzay",GendreId="blm",Price=55.78 },
                    new Book { Id = 10, Title = "Sırça Köşk",GendreId="syh",Price=99.99 },
                    new Book { Id = 11, Title = "Merhaba Dünya",GendreId="blm",Price=56.22 },
                    new Book { Id = 12, Title = "Beyaz Kale",GendreId="syh",Price=100 },
                    new Book { Id = 13, Title = "Beyaz Diş",GendreId="mcr",Price=44 },
                    new Book { Id = 14, Title = "Kafaya Takma Sanatı",GendreId="psk",Price=200 },
                    new Book { Id = 15, Title = "Bilge",GendreId="blm",Price=800 },
                    new Book { Id = 16, Title = "Mai",GendreId="syh",Price=289 }
                   

                );
        }
    }
}
