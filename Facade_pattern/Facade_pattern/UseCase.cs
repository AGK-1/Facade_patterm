using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_pattern
{
    public class UseCase
    {
        private readonly Ibankingoperationfacade _operationfacade;

        public UseCase(Ibankingoperationfacade operationfacade)
        {
            _operationfacade = operationfacade;
        }

        public void Run()
        {
            _operationfacade.opennewaccount("X024585","Jhon Vars",1000020);
            _operationfacade.closeaccount("S8511222");
            _operationfacade.handleloanapplication("Z1234567",15220);
        }
    }


}
