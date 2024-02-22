namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CustomerManager adında bir nesne oluşturulur.
            CustomerManager cm = new CustomerManager();

            // GercekMusteri adında bir nesne oluşturulur ve bu nesnenin özellikleri atanır
            GercekMusteri gercekM = new GercekMusteri();
            gercekM.Adi = "Edanur";
            gercekM.Soyadi = "Çağlayan";
            gercekM.MusteriNo = "12345";
            gercekM.TcNo = "2020";
            gercekM.Id = 9;

            // TuzelMusteri adında bir nesne oluşturulur ve bu nesnenin özellikleri atanır.
            TuzelMusteri tuzelM = new TuzelMusteri();
            tuzelM.Id = 7;
            tuzelM.SirketAdi = "Satuk";
            tuzelM.MusteriNo = "67890";
            tuzelM.VergiNo= "1234567";

            //Musteri adında iki nesne oluşturulur. musteri1 nesnesi GercekMusteri sınıfından,
            //musteri2 nesnesi ise TuzelMusteri sınıfından türetilir.
            Musteri musteri1 = new GercekMusteri();
            Musteri musteri2 = new TuzelMusteri();

            // CustomerManager sınıfının Add metodu, oluşturulan müşteri nesnelerini ekler.
            cm.Add(musteri1);
            cm.Add(musteri2);
            cm.Add(gercekM);
            cm.Add(tuzelM);

        }
    }
}
