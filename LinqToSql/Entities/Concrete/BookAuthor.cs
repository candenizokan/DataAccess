namespace LinqToSql.Entities.Concrete
{
    public class BookAuthor//ck=fk+pk
    {
        //ara tablolarda bir kere daha sql'in id vermesi istemez. çünkü bu aynı nesneyi defalarca ekleyebilmek demektir.

        // ara tablolarda composite key = foreign key + primary key olması söz konusudurç
        //iki id nin varlığı eşsiz anahtarı sağlar
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}