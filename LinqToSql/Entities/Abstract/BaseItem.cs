using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.Entities.Abstract
{
    public abstract class BaseItem<T> //Generic Type nerede t görsem Type
    {
        public T Id { get; set; }

        private DateTime _createdDate=DateTime.Now;

        public DateTime CreatedDate
        {
            get { return _createdDate=DateTime.Now; }
            set { _createdDate= value; }
        }

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        
    }
}
