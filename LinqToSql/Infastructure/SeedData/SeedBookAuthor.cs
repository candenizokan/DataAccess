using LinqToSql.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.Infastructure.SeedData
{
    internal class SeedBookAuthor : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasData
                (
                    new BookAuthor {AuthorId=1,BookId=2  },
                    new BookAuthor {AuthorId=2,BookId=8  },
                    new BookAuthor {AuthorId=10,BookId=9  },
                    new BookAuthor {AuthorId=1,BookId=9  },
                    new BookAuthor {AuthorId=3,BookId=2  },
                    new BookAuthor {AuthorId=3,BookId=8  },
                    new BookAuthor {AuthorId=4,BookId=11 },
                    new BookAuthor {AuthorId=10,BookId=10  },
                    new BookAuthor {AuthorId=8,BookId=14  },
                    new BookAuthor {AuthorId=6,BookId=15  },
                    new BookAuthor {AuthorId=3,BookId=16  },
                    new BookAuthor {AuthorId=4,BookId=1  },
                    new BookAuthor {AuthorId=5,BookId=3 },
                    new BookAuthor {AuthorId=6,BookId=4 },
                    new BookAuthor {AuthorId=2,BookId=5 },
                    new BookAuthor {AuthorId=7,BookId=6 },
                    new BookAuthor {AuthorId=2,BookId=7 },
                    new BookAuthor {AuthorId=7,BookId=12 },
                    new BookAuthor {AuthorId=4,BookId=13 }
                    
                );
        }
    }
}
