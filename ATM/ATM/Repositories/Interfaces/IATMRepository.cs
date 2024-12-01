using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Repositories.Interfaces
{
    internal interface IATMRepository
    {
        public bool UpdateATMStatus(ATMModel atm, bool isActive);
        public void DepositATMCash(ATMModel atm, float amount);
        public void CollectDepositedChecks(ATMModel atm, List<Cheque> cheques);


    }
}
