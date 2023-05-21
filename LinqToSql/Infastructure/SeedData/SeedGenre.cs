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
            throw new NotImplementedException();
        }
    }
}
