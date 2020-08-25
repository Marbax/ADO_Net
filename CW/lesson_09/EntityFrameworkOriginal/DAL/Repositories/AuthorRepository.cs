using DAL.Context;
using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DAL.Repositories
{
    public class AuthorRepository
    {
        private readonly BookShopContext _db = new BookShopContext();

        public Author Get(int id)
        {
            return _db.Authors.FirstOrDefault(x => x.AuthorId == id);
        }
        public IEnumerable<Author> GetAll()
        {
            return _db.Authors;
        }
        public void CreateOrUpdate(Author author)
        {
            _db.Authors.AddOrUpdate(author);
        }
        public void Delete(Author author)
        {
            _db.Authors.Remove(author);
        }
        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
