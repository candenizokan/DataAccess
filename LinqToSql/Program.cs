using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToSql.Infastructure.Context;
using AppContext = LinqToSql.Infastructure.Context.AppContext;

namespace LinqToSql
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //LinqToSql

            using (var db = new AppContext())
            {
                //tüm yazarları getirelim

                var list = db.Authors.ToList();

                //SELECT => seçim yapar. ilgili tablodan yalnızca yazdığımız kolonları seçer.

                var list2 = db.Authors.Select(a => new { a.Id, a.Statu, a.FirstName }).ToList();
            }
        }
    }
}
