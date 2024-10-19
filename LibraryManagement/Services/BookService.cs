using LibraryManagement.Models;
using LibraryManagement.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services
{
    internal class BookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository) {
        
            _bookRepository = bookRepository;
        }

        public void AddBook(Book book)
        {
            _bookRepository.Add(book);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.Update(book);
        }

        public void DeleteBook(Book book) { 
        
            _bookRepository.Delete(book);
        }
    }
}
