using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Repositories.Interfaces
{
    internal interface ITransactionRepository
    {
        public float GetBalance(string id);
        public bool WithdrawAmount(string id, float amount);
        public bool DepositAmount(string id, float amount);
        public bool DepositCheque(string id, Cheque checkDetails);
        public bool TransferFund(string id, float amount, RecieverAccountOfFund recieverAccountOfFund);

    }
}
