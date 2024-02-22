namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Müşterinin ekranda seçebileceği krediler
            IKrediManager ihtiyacKredi= new IhtiyacManager();
            IKrediManager tasitKredi = new TasitKrediManager();
            IKrediManager konutKredi = new KonutKrediManager();

            BasvuruManager basvuru = new BasvuruManager();
            basvuru.BasvuruYap(ihtiyacKredi, new DatabaseLoggerService());
            basvuru.BasvuruYap(tasitKredi, new FileLoggerService());
            basvuru.BasvuruYap(konutKredi,new DatabaseLoggerService());
            basvuru.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

            Console.WriteLine("------------");

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKredi, tasitKredi };
           // basvuru.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
