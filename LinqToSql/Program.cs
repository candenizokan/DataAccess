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



            #region WHERE
            //using (var db = new AppContext())
            //{
            //    //Where
            //    //birim fiyatı 30-90 arasında olan kitapların sadece isim ve fiyat bilgisini alıp basınız.

            //    var list = db.Books.Where(a => a.Price < 90 && a.Price > 30).Select(a => new { a.Title, a.Price }).ToList();

            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item.Title + " * " + item.Price);
            //    }

            //    // ismi a ile başlayan yazarları getiriniz

            //    var list2 = db.Authors.Where(a => a.FirstName.StartsWith("A")).ToList();

            //    //türü syh olan kitapları getiriniz

            //    var list3 = db.Books.Where(a => a.GendreId == "syh").ToList();

            //    Console.ReadLine();
            //} 
            #endregion


            #region ORDER BY
            //using (var db = new AppContext())
            //{
            //    // order by-- azdan çoka, a'dan zye, yakından uzak tarihe sıralama yapar.
            //    // order bydescending -- çoktan az, z'den a'ya, uzaktan yakın tarihi, vb sıralama yapar


            //    //id bilgisi 8-15 arasında olan (sınıfrlar dahil) yazarlar adlarına göre a dan z ye sıralayınız.

            //    var list = db.Authors.Where(a => a.Id <= 15 && a.Id >= 8).OrderBy(a => a.FirstName).ToList();

            //    // fiyatı 120 tl'den büyük kitapları pahalıdan ucuza sıralayıp yalnızca fiyat ve başlık kolonlarını seçiniz

            //    var list2 = db.Books.Where(a => a.Price > 120).Select(a => new { a.Price, a.Title }).OrderByDescending(a => a.Price).ToList();
            //} 
            #endregion


            #region First,single,default
            //using (var db = new AppContext())
            //{
            //    // FIRST() => tablodaki ilk kaydı getirir. getirebileceği bir kayıt yoksa hata fırlatır.
            //    // FIRSTORDEFAULT() => tablodaki ilk kaydı getirir ama kayıt yoksa hata vermez.

            //    // SINGLE() => tablodaki şartı sağlayan ilk kaydı getirir ANCAK FIRST() den farklı olarak şartı sağlayan tek nesne olmasını ister. Tek nesne yoksa yada birden fazla nesne varsa hata verir.

            //    // SINGLEORDEFAULT() => şartı sağlayan tek nesneyi döndürür ancak yoksa hata vermez default değer döndürür. Çok nesne varsa da hata verir

            //    var list = db.Books.First();

            //    var list2 = db.Books.Where(a => a.Price < 100 && a.Price > 30).First();
            //    var list3 = db.Books.Where(a => a.Price < 10000 && a.Price > 3000).First();

            //    var list4 = db.Books.Where(a => a.Price < 100 && a.Price > 30).FirstOrDefault();
            //    var list5 = db.Books.Where(a => a.Price < 10000 && a.Price > 3000).FirstOrDefault();

            //    var list6 = db.Books.Where(a => a.Price < 100 && a.Price > 30).Single();
            //    var list7 = db.Books.Where(a => a.Price < 10000 && a.Price > 3000).Single();

            //    var list8 = db.Books.Where(a => a.Price < 100 && a.Price > 30).SingleOrDefault();
            //    var list9 = db.Books.Where(a => a.Price < 10000 && a.Price > 3000).SingleOrDefault();

            //    var list10 = db.Books.Where(a => a.Price == 56.22).SingleOrDefault();
            //    var list11 = db.Books.Where(a => a.Price == 56.22).Single();

            //    try
            //    {
            //        //hata alacağını düşündüğümüz kodları try içine 
            //        var book = db.Books.First(a => a.Price == -80);
            //        Console.WriteLine($"{book.Id} - {book.Title}");
            //    }
            //    catch (Exception ex)
            //    {
            //        //hata alındığında çalışacak kodları catch bloğu içine yaz.
            //        Console.WriteLine("her hangi bir kayıt bulunamadi {0}", ex.Message);
            //    }
            //} 
            #endregion

            #region FIND
            //using (var db = new AppContext())
            //{
            //    //FIND() => anahtar ifadeye göre filtreleme yaparak nesneyi bulur ve döndürür.

            //    var genre = db.Gendres.Find("mcr");
            //    var boog = db.Books.Find(1);
            //    var book2 = db.Books.Find(600);
            //} 
            #endregion


            #region Take
            using (var db = new AppContext())
            {
                //TAKE(n) => almak, n: kaç adet eleman alınacak

                //Fiyatı en yüksek olan 5 kitabı bulunuz ve sadece kitap adı ve fiyatını desc olarak sıralı getiriniz.

                var list = db.Books.Take(5).OrderByDescending(a => a.Price).Select(a => new { a.Title, a.Price }).ToList();

                foreach (var item in list)
                {
                    Console.WriteLine(item.Title + " * " + item.Price);
                }

                Console.ReadLine();
            } 
            #endregion

        }
    }
}
