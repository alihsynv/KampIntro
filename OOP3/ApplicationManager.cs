using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
