using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    internal class ATMModel
    {
        public Guid Id { get; set; }
        public string? Location { get; set; }
        public int CurrentWithdrawableAmount { get; set; }
        public int DepositedAmount { get; set; }
        public bool IsActive { get; set; }

    }
}
