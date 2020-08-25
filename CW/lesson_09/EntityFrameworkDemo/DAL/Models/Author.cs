using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(80)]
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
