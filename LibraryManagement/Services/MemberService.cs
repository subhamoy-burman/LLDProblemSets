using LibraryManagement.Models;
using LibraryManagement.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services
{
    internal class MemberService
    {
        private readonly IMembersRepository _membersRepository;
        public MemberService(IMembersRepository membersRepository) {
            _membersRepository = membersRepository;
        }

        public void AddNewMember(Members member)
        {
            _membersRepository.AddNewMember(member);
        }

        //Similarly for others like Cancel, Extend etc
    }
}
