using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    internal class Members
    {
        public string? MembershipID { get; set; }
        public string? MemberName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }


        public List<Book> GetBooks()
        {
            return new List<Book>();
        }

        public void ReserveABook(Book book) { 
        }

        public void GetNotification(Book book)
        {

        }


    }


}
