using LibraryManagement.Models;
using LibraryManagement.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repositories
{
    internal class MembersRepository : IMembersRepository
    {
        public void AddNewMember(Members member)
        {
            throw new NotImplementedException();
        }

        public void CancelMembership(Members member)
        {
            throw new NotImplementedException();
        }

        public void ExtendMembership(Members member, DateOnly date)
        {
            throw new NotImplementedException();
        }

        public void SuspendMembership(Members member)
        {
            throw new NotImplementedException();
        }
    }
}
