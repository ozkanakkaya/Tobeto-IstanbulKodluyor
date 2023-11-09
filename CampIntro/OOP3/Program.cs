using OOP3;

ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
ICreditManager transportCreditManager = new TransportCreditManager();
ICreditManager houseCreditManager = new HouseCreditManager();
ICreditManager tradeCreditAppManager = new TradeCreditApplicationManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();
List<ILoggerService > loggers = new List<ILoggerService>() { new SmsLoggerService(), new FileLoggerService()};

//interfaceler class'ın referans numarasını tutabilir.

ApplicationManager applicationManager = new ApplicationManager();
applicationManager.ToApply(tradeCreditAppManager, smsLoggerService);
applicationManager.ToApply(loggers);

List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCreditManager, transportCreditManager };

applicationManager.CreditInfoPreCheck(credits);