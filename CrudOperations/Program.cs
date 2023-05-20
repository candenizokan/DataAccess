using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
             CRUD=> Crun operations

            Create=> yeni bir nesne oluşturma ve veritabanına ekleme
            Read=> bir filtreleme, sorgu dahilinde bir / birkaç tane nesneyi veritabanından çekip okumaya çalışmak.
            Update=> bir filtreleme dahilinde bir yada birkaç nesnenin güncellenmesi
            Delete=> bir filtre yada sorgu dahilinde ilgili nesne/nesneleri siler
             
             
             */

            using (var db=new AppDbContext())
            {
                Category category = new Category();

                category.Name = "Elektronik";
                category.Description = "Çok pahalandı";

                db.Categories.Add(category);
                int result = db.SaveChanges();

                if (result>0)
                {
                    Console.WriteLine("Ekleme işlemi başarılı");
                }
                else
                {
                    Console.WriteLine("Ekleme işlemi başarısız.");
                }

                Category category1 = new Category()
                {
                    Name = "Sebze",
                    Description = "Manav reyonu"
                };
                
                
                db.Categories.Add(category1);
                db.SaveChanges();

                Console.ReadLine();
            }
        }
    }
}
