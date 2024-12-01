using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.StateMachine
{
    internal class ATMStateMachine
    {
        private static ATMStateMachine? _instance;
        public static ATMStateMachine Instance {
            get
            {
                if (_instance == null)
                { 
                    _instance = new ATMStateMachine();
                    return _instance;
                }
                else 
                    return _instance;
            }
            
        }
        public ATMState CurrentState { get; private set; } = ATMState.Idle;

        public event Action<ATMState>? OnStateChanged;

        private ATMStateMachine() { }

        public void TransitionTo(ATMState newState)
        {
            CurrentState = newState;
            OnStateChanged?.Invoke(newState);
        }
    }
}
