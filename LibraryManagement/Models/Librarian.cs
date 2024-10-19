using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    internal class Librarian : Members
    {
        public string? LibrarianId { get; set; }

        public void IssueBook(Book book, Members member)
        {

        }

        public void ReturnBook(Book book, Members member) { 

        }

        private int CalculateFine(Book book)
        {
            return 0;
        }

        public void AddBookToCatalogue(Book book)
        {

        }

        public void PlaceBookInARack(Book book) { 

        }

        public void UpdateBook(Book book)
        {
            //Update By ISBN Number, so all books will be updated
        }

    }
}
