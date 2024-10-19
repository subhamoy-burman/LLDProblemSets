using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.Interfaces
{
    internal interface IScheduleEmail
    {
        public void ScheduleEmail(Members member);
    }
}
