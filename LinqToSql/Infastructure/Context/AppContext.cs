using LinqToSql.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.Infastructure.Context
{
    public class AppContext :DbContext
    {
        //connectionstring
        //dbset - oluşacak tablolar
        // konfigurasyon

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GNRM-LAB05-PC15;Database=LinqToSql;User Id=sa;Password=123;");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Gendre> Gendres { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
    }
}
