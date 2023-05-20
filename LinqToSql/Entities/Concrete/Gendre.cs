using LinqToSql.Entities.Abstract;
using System.Collections.Generic;

namespace LinqToSql.Entities.Concrete
{
    public class Gendre:BaseItem<string>
    {

        public string Name { get; set; }

        //navigation property
        public ICollection<Book> Books { get; set; }//tür için çokça kitap barındırdım
    }
}