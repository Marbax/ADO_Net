using DAL.Repositories;
using System;

namespace EntityFramework
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BookRepository repo = new BookRepository();
            foreach (var book in repo.GetAll())
                Console.WriteLine(book.Title);

            //repo.CreateOrUpdate(new Book { Title = "Some book" });
            //repo.Save();

            //Book hp = repo.GetAll().FirstOrDefault(x => x.Title.ToLower().Contains("язык"));
            //if (hp != null)
            //{
            //    repo.Delete(hp);
            //    repo.Save();
            //}




            //using (BookShopContext db = new BookShopContext())
            //{

            //    IQueryable<Book> result = db.Books;


            //    foreach(var b in result.Where(x => x.BookId > 1))
            //        Console.WriteLine(b.Title);

            //}
        }
    }
}
