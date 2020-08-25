using System.Collections.Generic;
using System.Linq;
using DAL.Models;
using DAL.Repositories;

namespace BookAuthorGUI.ViewModels
{
    class MainViewModel
    {
        BookRepository _bookRepository;
        AuthorRepository _authorRepository;
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
        public MainViewModel()
        {
            _bookRepository = new BookRepository();
            Books = _bookRepository.GetAll().ToList();

            _authorRepository = new AuthorRepository();
            Authors = _authorRepository.GetAll().ToList();

        }
    }
}
