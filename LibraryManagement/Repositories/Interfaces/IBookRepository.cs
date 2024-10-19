using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repositories.Interfaces
{
    internal interface IBookRepository
    {
        void Add(Book book);
        void Update(Book book);
        Book GetByISBN(string isbn);
        void Delete(Book book);
        void IssueBook(Members member, Book book);
        void ReturnBook(Members member, Book book);
        List<BookIssuanceHistory> GetBookIssuanceHistory(Book book);
    }
}
