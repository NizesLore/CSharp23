//Interface
using Oop3;
IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager konutKrediManager=new KonutKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();

ILoggerService databaseLoggerSercive = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService()};

BasvuruManager basvuruManager = new BasvuruManager();
//basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> { new DatabaseLoggerService(),
//new SmsLoggerService() });

basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);


List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

