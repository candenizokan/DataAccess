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

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

    }
}
