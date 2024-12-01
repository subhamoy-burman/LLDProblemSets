using ATM.Models;
using ATM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services.Implementations
{
    internal class BankingCustomerAction : IBankingCustomerAction
    {
        public void DepositAmount(int amount)
        {
            throw new NotImplementedException();
        }

        public void DepositCheck(Cheque cheque)
        {
            throw new NotImplementedException();
        }

        public void EnquireBalance()
        {
            throw new NotImplementedException();
        }

        public void TransferFund(RecieverAccountOfFund recieverAccount)
        {
            throw new NotImplementedException();
        }

        public void WithdrawAmount(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
