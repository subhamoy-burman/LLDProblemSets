using LibraryManagement.Models;
using LibraryManagement.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services
{
    internal class BookIssuanceService
    {
        private readonly IBookRepository _bookRepository;
        public BookIssuanceService(IBookRepository bookRepository) {
            _bookRepository = bookRepository;
        }

        public void IssueBook(Members member, Book book)
        {
            _bookRepository.IssueBook(member, book);
        }

        public void ReturnBook(Members member, Book book) { 
            _bookRepository.ReturnBook(member,book);
        }

        public List<BookIssuanceHistory> GetListOfIssueHistory(Book book)
        {
            return _bookRepository.GetBookIssuanceHistory(book);
        }

        private int calculateFine(Book book, DateTime returnDate)
        {
            return -1;
        }
    }
}
