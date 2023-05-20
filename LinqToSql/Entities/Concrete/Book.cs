using LinqToSql.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.Entities.Concrete
{
    public class Book:BaseItem<int>
    {
        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        [MinLength(2, ErrorMessage ="En az 2 karakter yazınız")]
        [MaxLength(200, ErrorMessage = "En fazla 200 karakter yazınız")]
        public string Title { get; set; }

        [Range(0.0,1000.0,ErrorMessage ="0 ile 1000 arasında değer yazınız")]
        public double Price { get; set; }

        //NavigationProp


        //1 kitabın çokça bookauthor nesnesi olabilir

        public ICollection<BookAuthor> BookAuthors { get; set; }//kitabınyazarları

        //1 kitabın 1 türü olur
        public string GendreId { get; set; }
        public Gendre Gendre { get; set; }

    }
}
