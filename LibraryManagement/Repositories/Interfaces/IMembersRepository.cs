using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repositories.Interfaces
{
    internal interface IMembersRepository
    {
        public void AddNewMember(Members member);
        public void CancelMembership(Members member);
        public void SuspendMembership(Members member);

        public void ExtendMembership(Members member, DateOnly date);
    }
}
