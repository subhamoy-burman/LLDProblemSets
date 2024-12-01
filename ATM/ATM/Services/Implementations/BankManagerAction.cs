using ATM.Models;
using ATM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services.Implementations
{
    internal class BankManagerAction : IBankManagerAction
    {
        public void GenerateReport(ATMModel atm)
        {
            throw new NotImplementedException();
        }

        public void UpdateATMStatus(ATMModel atm, bool isActive)
        {
            throw new NotImplementedException();
        }
    }
}
