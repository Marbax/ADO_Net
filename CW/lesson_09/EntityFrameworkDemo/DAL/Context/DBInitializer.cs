using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Context
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<BookShopContext>
    {
        protected override void Seed(BookShopContext context)
        {
            Book b1 = new Book { Title = "Under the down" };
            Book b2 = new Book { Title = "War of The Mane" };
            Book b3 = new Book { Title = "Sadly Harry" };
            Book b4 = new Book { Title = "Under the down" };

            Author a1 = new Author { Name = "Larisa Okipna" };
            Author a2 = new Author { Name = "Evgeniy Petrov" };
            Author a3 = new Author { Name = "Zaycev Zayac" };
            Author a4 = new Author { Name = "joan Rouling" };

            b1.Authors.Add(a4);
            b2.Authors.Add(a3);
            b3.Authors.Add(a2);
            b4.Authors.Add(a1);
            b4.Authors.Add(a2);

            a1.Books.Add(b4);
            a2.Books.Add(b4);
            a2.Books.Add(b3);
            a3.Books.Add(b2);
            a4.Books.Add(b1);

            context.Books.AddRange(new List<Book> { b1, b2, b3, b4 });
            context.Authors.AddRange(new List<Author> { a1, a2, a3, a4 });

            context.SaveChanges();
        }

    }
}
