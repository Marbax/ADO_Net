using DAL.Context;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BookRepository bRepo = new BookRepository();
            bRepo.CreateOrUpdate(new Book { Title = "Bok bok" });

            Book hp = bRepo.GetAll().FirstOrDefault(b => b.Title.ToLower().Contains("harry potter"));
            bRepo.Delete(hp);
            bRepo.Save();

            //
            //using (BookShopContext db = new BookShopContext())
            //{
            //
            //    IQueryable<Book> res = db.Books;
            //
            //    res.Where(b => b.BookId > 0).ToList().ForEach(b => Console.WriteLine(b));
            //}


        }
    }
}
