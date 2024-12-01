using ATM.Repositories.Interfaces;
using ATM.Services.Interfaces;
using ATM.StateMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services.Implementations
{
    internal class ATMService : IATMService
    {
        private readonly IATMRepository _atmRepository;
        private readonly ATMStateMachine _stateMachine;
        private readonly IScreenService _screenService;

        public ATMService(IATMRepository atmRepository, ATMStateMachine stateMachine, IScreenService screenService)
        {
            _atmRepository = atmRepository;
            _stateMachine = stateMachine;
            _stateMachine.OnStateChanged += NotifyStateChange;
            _screenService = screenService;
        }

        private void NotifyStateChange(ATMState state)
        {
            if (state == ATMState.Error)
            {
                _screenService.ShowMessage("ATM is in errored state");
            }
        }
    }
}
