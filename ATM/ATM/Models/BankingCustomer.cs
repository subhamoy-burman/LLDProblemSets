using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    internal class BankingCustomer : User       
    {
        public int AccountNumber { get; set; }
        public string BranchName { get; set; }
        = null!;
        public string IFSCCode { get; set; } = null!;
    }
}
