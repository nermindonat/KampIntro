﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerfService();
            ILoggerService fileLoggerService = new FileLoggerfService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerfService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
