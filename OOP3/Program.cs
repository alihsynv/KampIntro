using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoogerService();
            ILoggerService fileLoggerService = new FileLoogerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.BasvuruYap(transportCreditManager, new List<ILoggerService>{new DatabaseLoogerService(), new FileLoogerService() });
            
            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager, transportCreditManager };

            

            //applicationManager.KrediOnBilgilendirmesiYap(credits);

        }
    }
}
