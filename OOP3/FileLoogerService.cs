using System;

namespace OOP3
{
    class FileLoogerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandi");
        }
    }
}
