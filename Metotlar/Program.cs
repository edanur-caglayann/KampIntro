using Metotlar;

class Program
{
    static void Main(string[] args)
    {
        // Metotlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyat = 15;
        urun1.Aciklama = "Amasya Elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyat = 30;
        urun2.Aciklama = "Küçük Karpuz";

        Urun[] urunler = new Urun[] { urun1, urun2};


        /* in urunler : urunler dizisini ekrana basacak
        Dizideki elemanları tek tek dolaşırken o anki değere urun diyoruz(x de olabilirdi)
        Urun : veri tipidir. Onun yerine 'var' da diyebilirz.
        Var arka planda onu Urun olarak algılıyor.
         */
        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.Adi + "-"+ urun.Aciklama + "-"+urun.Fiyat);
        }

        Console.WriteLine("-----Metotlar-----");

        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);

        sepetManager.EkleAlternatif("Çilek", "1 Kilo", 35, 20);
        
    }
}
