using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services.Interfaces
{
    internal interface IBankManagerAction
    {
        public void GenerateReport(ATMModel atm);
        public void UpdateATMStatus(ATMModel atm, bool isActive);
    }
}
