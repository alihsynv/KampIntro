using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DatabaseLoogerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanina loglandi");
        }
    }
}
