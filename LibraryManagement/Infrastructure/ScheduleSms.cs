using LibraryManagement.Infrastructure.Interfaces;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure
{
    internal class ScheduleSms : IScheduleSms
    {
        void IScheduleSms.ScheduleSms(Members member)
        {
            throw new NotImplementedException();
        }
    }
}
