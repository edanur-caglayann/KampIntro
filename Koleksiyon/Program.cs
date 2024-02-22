using System.Collections.Generic;

namespace Koleksiyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Eda","Satuk","Buğra","Güneş"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            Console.WriteLine("---------------------");
            /*
             * isimler[4] = "Toprak";
             * Console.WriteLine(isimler[4]);
             * dersek hata alırız çünkü dizinin boyutunu aşmış oluruz.
             * Bu yüzden bu gibi durumlarda dizileri kullanmak verimli olmaz.
             * isimler = new string[4]; diyip isimler[4] = "Toprak"; dersekte 
             * eski elemanlara ulaşamayız çünkü new diyerek yeni referans adresi oluşturmuş
             * olduk. Dizi de sabit alan vardır bu yüzden bu tür kullanımları kaldırmaz.
             * Bunun yerine liste yapısını kullanabiliriz
             */

            // Aşağıdaki 'List' aslında arka tarafta bir dizi yönetiyor, kullanıyor.

            List<string> list = new List<string> { "Eda", "Satuk", "Buğra", "Güneş" };

            // List<string> list = new List<string>();
            // list.Add(isimler[0]); olarak da kullanılır.
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
            Console.WriteLine(list[3]);
            list.Add("İlker");
            Console.WriteLine(list[4]);


        }
    }
}
