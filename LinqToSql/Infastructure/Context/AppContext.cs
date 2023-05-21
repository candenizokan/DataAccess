using LinqToSql.Entities.Concrete;
using LinqToSql.Infastructure.SeedData;
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



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //set primarykey
            modelBuilder.Entity<BookAuthor>().HasKey(a=> new {a.AuthorId,a.BookId});

            modelBuilder.Entity<Author>().HasKey(e => e.Id);
            modelBuilder.Entity<Gendre>().HasKey(t => t.Id);

            //set foreign key
           // bir yazarın çokça kitapları vardır. bunlar birbirine bağlıdır bookauthor üzerinden
            modelBuilder.Entity<BookAuthor>().HasOne(a=>a.Author).WithMany(a=>a.BookAuthors).HasForeignKey(r=>r.AuthorId);
            modelBuilder.Entity<BookAuthor>().HasOne(a=>a.Book).WithMany(a=>a.BookAuthors).HasForeignKey(a=>a.BookId);

            //kitap sınıfı içerisinde bir tane tür vardır. türde çokça kitap vardır. bağlıdır gendreid üzerinden
            modelBuilder.Entity<Book>().HasOne(a=>a.Gendre).WithMany(a=>a.Books).HasForeignKey(a=>a.GendreId);




            modelBuilder.ApplyConfiguration(new SeedAuthor());
            modelBuilder.ApplyConfiguration(new SeedBook());
            modelBuilder.ApplyConfiguration(new SeedBookAuthor());
            modelBuilder.ApplyConfiguration(new SeedGenre());
           
            //add-migration komutunu anlayan paket var. onu nugetten almam lazım ef core tools

            base.OnModelCreating(modelBuilder);
        }
    }
}
