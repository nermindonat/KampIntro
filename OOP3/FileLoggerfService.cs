using System;

namespace OOP3
{
    class FileLoggerfService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
