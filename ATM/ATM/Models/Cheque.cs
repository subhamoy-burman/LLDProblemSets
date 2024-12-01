using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    internal class Cheque
    {
        public Guid Id { get; set; }
        public int  ChequeNumber { get; set; }
        public int  CheckMoneraryAmount { get; set; }
        public BankingCustomer? ChequeIssuedByCustomer { get; set; }

        /// <summary>
        /// Tuple would define Recievers Account Number, IFSC code, Bank Address
        /// </summary>
        public (int,int,string) CheckIssuedTo {  get; set; }
    }
}
