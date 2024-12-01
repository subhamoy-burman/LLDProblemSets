using ATM.Models;
using ATM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services.Implementations
{
    internal class ATMOperationAction : IATMOperatorAction
    {
        public void CollectDepositedCash(ATMModel atm, int amount)
        {
            throw new NotImplementedException();
        }

        public void CollectDespositedChecks(ATMModel atm, List<Cheque> checks)
        {
            throw new NotImplementedException();
        }

        public void DepositCashInATM(ATMModel atm, int amount)
        {
            throw new NotImplementedException();
        }

        public void RefillATMInk(ATMModel atm)
        {
            throw new NotImplementedException();
        }

        public void RefillPrintPaper(ATMModel atm)
        {
            throw new NotImplementedException();
        }
    }
}
