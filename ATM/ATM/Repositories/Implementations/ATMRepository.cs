using ATM.Models;
using ATM.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Repositories.Implementations
{
    internal class ATMRepository : IATMRepository
    {
        public void CollectDepositedChecks(ATMModel atm, List<Cheque> cheques)
        {
            throw new NotImplementedException();
        }

        public void DepositATMCash(ATMModel atm, float amount)
        {
            throw new NotImplementedException();
        }

        public bool UpdateATMStatus(ATMModel atm, bool isActive)
        {
            throw new NotImplementedException();
        }
    }
}
