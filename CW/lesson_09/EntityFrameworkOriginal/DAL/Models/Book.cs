using System.Collections.Generic;

namespace DAL.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}
