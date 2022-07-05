using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        private SubSystemA _subSystemA = new SubSystemA();
        private SubSystemB _subSystemB = new SubSystemB();
        private SubSystemC _subSystemC = new SubSystemC();

        public void OperationAB()
        {
            _subSystemA.Operation();
            _subSystemB.Operation();
        }
        public void OperationBC()
        {
            _subSystemB.Operation();
            _subSystemC.Operation();
        }
    }
}
