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

        public void EnquireBalance()
        {

        }

        public void WithdrawAmount(int amount)
        {

        }

        public void DepositAmount(int amount) { 
        
        }

        public void DepositCheck(Cheque cheque) {

        }

        public void TransferFund(RecieverAccountOfFund recieverAccount) { 
        

        }
    }
}
