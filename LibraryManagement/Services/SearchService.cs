using LibraryManagement.Models;
using LibraryManagement.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services
{
    internal class SearchService
    {
        private readonly IBookRepository _bookRepository;
        public SearchService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return new List<Book>();
        }

        public List<Book> GetBookByTitle(string title)
        {
            return new List<Book>();
        }
    }
}
