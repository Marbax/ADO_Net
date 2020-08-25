using DAL.Models;
using System.Data.Entity;

namespace DAL.Context
{
    public class BookShopContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public BookShopContext() : base("name=BookShopCS")
        {
            Database.SetInitializer(new DBInitializer());
        }
    }
}
