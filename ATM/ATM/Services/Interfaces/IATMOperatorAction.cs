using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services.Interfaces
{
    internal interface IATMOperatorAction
    {
        public void DepositCashInATM(ATMModel atm, int amount);

        public void CollectDepositedCash(ATMModel atm, int amount);

        public void CollectDespositedChecks(ATMModel atm, List<Cheque> checks);

        public void RefillATMInk(ATMModel atm);
        public void RefillPrintPaper(ATMModel atm);
    }
}
