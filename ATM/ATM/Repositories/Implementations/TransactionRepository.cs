using ATM.Models;
using ATM.Repositories.Interfaces;
using ATM.StateMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Repositories.Implementations
{
    internal class TransactionRepository : ITransactionRepository
    {
        public bool DepositAmount(string id, float amount)
        {
            throw new NotImplementedException();
        }

        public bool DepositCheque(string id, Cheque checkDetails)
        {
            throw new NotImplementedException();
        }

        public float GetBalance(string id)
        {
            throw new NotImplementedException();
        }

        public bool TransferFund(string id, float amount, RecieverAccountOfFund recieverAccountOfFund)
        {
            if(ATMStateMachine.Instance.CurrentState == ATMState.Error)
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public bool WithdrawAmount(string id, float amount)
        {
            throw new NotImplementedException();
        }
    }
}
