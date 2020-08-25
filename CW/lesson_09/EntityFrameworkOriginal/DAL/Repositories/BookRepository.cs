using DAL.Context;
using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DAL.Repositories
{
    public class BookRepository
    {
        private readonly BookShopContext _db = new BookShopContext();

        public Book Get(int id)
        {
            return _db.Books.FirstOrDefault(x => x.BookId == id);
        }
        public IEnumerable<Book> GetAll()
        {
            return _db.Books;
        }
        public void CreateOrUpdate(Book book)
        {
            _db.Books.AddOrUpdate(book);
        }
        public void Delete(Book book)
        {
            _db.Books.Remove(book);
        }
        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
