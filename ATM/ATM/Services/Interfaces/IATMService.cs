using ATM.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services.Interfaces
{
    internal interface IATMService
    {
        public void InitiateOperation(Card card)
        {

        }

        public void DispenseCash(int amount)
        {

        }

        public void Print(ExpandoObject information)
        {

        }

    }
}
