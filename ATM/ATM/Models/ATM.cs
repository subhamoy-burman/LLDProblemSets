using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    internal class ATM
    {
        public Guid Id { get; set; }
        public string? Location { get; set; }
        public int CurrentWithdrawableAmount { get; set; }
        public int DepositedAmount { get; set; }
        public bool IsActive { get; set; }


        public void UpdateATMStatus(bool isActive)
        {
            this.IsActive = isActive;
        }

        public void AddCashInATM(int amount) { 

        }

        public void RefillPrinter()
        {

        }

        public void GenerateReport()
        {

        }

        public void DispenseCash(int amount)
        {

        }

        public void Print(ExpandoObject information)
        {

        }

        public (UserTypes,bool) Authenticate(string cardNumber, string pin)
        {
            throw new NotImplementedException();
        }


    }
}
