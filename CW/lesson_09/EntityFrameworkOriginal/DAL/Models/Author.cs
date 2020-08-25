﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
