class Program
{
    static void Main(String[] args)
    {
        /* Main metodunda, Kurs sınıfından üç farklı nesne(Object)
         * oluşturduk. kurs1, kurs2, kurs3
         * Her bir kurs için özelliklere değerler atadık.
         */
        Kurs kurs1 = new Kurs();
        kurs1.KursAdı = "C#";
        kurs1.Egitmen = "Eda";
        kurs1.IzlenmeOrani = 93;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdı = ".Net";
        kurs2.Egitmen = "Satuk";
        kurs2.IzlenmeOrani = 70;

        Kurs kurs3 = new Kurs();
        kurs2.KursAdı = "Java";
        kurs2.Egitmen = "Buğra";
        kurs2.IzlenmeOrani = 67;

        Console.WriteLine(kurs1.KursAdı + ":" + kurs1.Egitmen);

        /* Oluşturulan bu üç kurs nesnesini, Kurslar adında 
         * bir diziye ekledik.
         */
        Kurs[] Kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
        foreach (var x in Kurslar) 
        {
        Console.WriteLine(x.KursAdı + "-" + x.Egitmen + "-"+ x.IzlenmeOrani);
        }
    }
}

/* Kurs adında bir class tanımladık.
 * Bu classın 3 özelliği(property) var: KursAdı, Eğitmen, İzlenmeOranı
 */
class Kurs
{
    public string KursAdı { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}
