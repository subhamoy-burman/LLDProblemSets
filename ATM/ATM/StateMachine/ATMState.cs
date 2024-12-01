using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.StateMachine
{
    public enum ATMState
    {
        Idle,
        CardInserted,
        PinEntered,
        TransactionSelected,
        TransactionProcessing,
        TransactionCompleted,
        Error
    }
}
