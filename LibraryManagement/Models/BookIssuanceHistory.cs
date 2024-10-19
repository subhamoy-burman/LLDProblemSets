using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    internal class BookIssuanceHistory
    {
        public string? MemberId { get; set; }
        public DateTime BookIssueStartTime { get; set; }
        public DateTime? BookReturnedDateTime { get; set; }
    }
}
