using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToSql.Entities.Concrete;
using LinqToSql.Infastructure.Context;
using AppContext = LinqToSql.Infastructure.Context.AppContext;

namespace LinqToSql
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //LinqToSql

            #region Select
            //using (var db = new AppContext())
            //{
            //    //tüm yazarları getirelim

            //    var list = db.Authors.ToList();

            //    //SELECT => seçim yapar. ilgili tablodan yalnızca yazdığımız kolonları seçer.

            //    var list2 = db.Authors.Select(a => new { a.Id, a.Statu, a.FirstName }).ToList();

            //    //daha küçük bir protatip gibi sunabilirim.
            //    var list3 = db.Authors.Select(a => new Calisan { Ad = a.FirstName, Soyad = a.LastName }).ToList();
            //} 
            #endregion



            using (var db = new AppContext())
            {
                //Where
                //birim fiyatı 30-90 arasında olan kitapların sadece isim ve fiyat bilgisini alıp basınız.

                var list = db.Books.Where(a=> a.Price<90 && a.Price > 30).Select(a => new {a.Title, a.Price}).ToList();

                foreach (var item in list)
                {
                    Console.WriteLine(item.Title+" * "+item.Price);
                }

                // ismi a ile başlayan yazarları getiriniz

                var list2 = db.Authors.Where(a=> a.FirstName.StartsWith("A")).ToList();

                //türü syh olan kitapları getiriniz

                var list3 = db.Books.Where(a => a.GendreId == "syh").ToList();

                Console.ReadLine();
            }
        }
    }
}
