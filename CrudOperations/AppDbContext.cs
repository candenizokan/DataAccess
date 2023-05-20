using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations
{
    //veritabanı ile konuşan sınıf. bunu dbcontexten kalıtım alıyorum.
    internal class AppDbContext:DbContext
    {

        //connection string yazıyorum. override edip eziyorum

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GNRM-LAB05-PC15;Database=DBCrudOperation;User Id=sa;Password=123;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //kendi konfigurasyonlarımızı çağırırız.
        //    base.OnModelCreating(modelBuilder);
        //}

        //tablo oluşturma
        public DbSet<Category> Categories { get; set; }

        //migration=göç tüm kodları yazdım uygulama tarafında veritabı tarafında bir göç başlatıyorum
        //add-migration buna isim vermem lazım add-migration one
        //sonra update-database ile migrationu uyguladı
    }
}
