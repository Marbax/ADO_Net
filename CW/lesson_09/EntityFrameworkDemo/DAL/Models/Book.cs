using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    //[Table("Book")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [StringLength(80)]
        public string Title { get; set; }

        public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}
