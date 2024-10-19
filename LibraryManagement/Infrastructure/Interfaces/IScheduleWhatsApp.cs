using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.Interfaces
{
    internal interface IScheduleWhatsApp
    {
        public void ScheduleWhatsAppMessage(Members member);
    }
}
