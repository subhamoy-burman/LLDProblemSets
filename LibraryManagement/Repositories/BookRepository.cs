using LibraryManagement.Models;
using LibraryManagement.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repositories
{
    internal class BookRepository : IBookRepository
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetByISBN(string isbn)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book book)
        {
            throw new NotImplementedException();
        }

        public void IssueBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void ReturnBook(Book book)
        {
            throw new NotImplementedException();
        }

        public List<BookIssuanceHistory> GetBookIssuanceHistory(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
