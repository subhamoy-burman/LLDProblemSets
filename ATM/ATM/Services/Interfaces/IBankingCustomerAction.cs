using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services.Interfaces
{
    internal interface IBankingCustomerAction
    {
        public void EnquireBalance();

        public void WithdrawAmount(int amount);

        public void DepositAmount(int amount);

        public void DepositCheck(Cheque cheque);

        public void TransferFund(RecieverAccountOfFund recieverAccount);
        
    }
}
