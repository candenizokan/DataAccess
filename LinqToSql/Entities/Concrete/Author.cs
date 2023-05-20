using LinqToSql.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.Entities.Concrete
{
    public class Author:BaseItem<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        //NAVIGATION PROPERTY
        //Bu sınıfın ilişkili olduğu diğer sınıfları konfigurasyonları yaparken bu propertyler üzerinden açıklarız.
        //veri çekmek ve tablolar arası ilişkiyi kurgulamak i.in navigation propertylere ihtiyacımız var.
        // Navigation proplar karşılıklı her iki sınıftada KESİNLİKLE TANIMLANIR ancak İLİŞKİYİ AÇIKLANIRKEN TEK TARAFTAN AÇIKLANMASI YETERLİDİR.

        public ICollection<BookAuthor> BookAuthors { get; set; }///yazar id yazar nesnesi kitap id kitap nesnesi

        //eager loading default olan üsteki
        //lazy loading  public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
