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
    public class SeedGenre : IEntityTypeConfiguration<Gendre>
    {
        public void Configure(EntityTypeBuilder<Gendre> builder)
        {
            builder.HasData
                (
                    new Gendre { Id = "kor",Name ="Korku"},
                    new Gendre { Id = "psk",Name ="Psikoloji"},
                    new Gendre { Id = "mcr",Name ="Macera"},
                    new Gendre { Id = "syh",Name ="Seyehat"},
                    new Gendre { Id = "blm",Name ="Bilim"}
                
                );
        }
    }
}
