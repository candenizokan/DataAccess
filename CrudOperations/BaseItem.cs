using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations
{
    internal class BaseItem
    {
        public int ID { get; set; }

        private DateTime _createdDate=DateTime.Now;

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate= value; }
        }

        public DateTime? UpdateDate { get; set; }// ? ilgili prop klon olarak oluşturulurken NULLABLE işaretlensin
        public DateTime? DeleteDate { get; set; }

        private Statu _statu=Statu.Active;

        public Statu Statu
        {
            get { return _statu; }
            set { _statu= value; }
        }


    }
}
