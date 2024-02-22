using System;
namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1); // Sayi1 20 çıkar. 

            /* int, decimal, float, double, bool = değer tipi
             */ 


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); // sayilar1[0] = 999 çıkar.

            /* array, class, interface = referans tipi
             */

             /*Bellekte stack ve heap adında iki alan var. Değer tipi olanlar stack de yer alır.
             * sayi1 = 10, sayi2 = 20 sayi1'in değeri 10 , sayi2'nin değeri 20 olarak okunur.
             * sayi1 = sayi2 dediğimiz noktada sayi1'in değeri sayi2 olur diyoruz
             */

            /* Referans tiplerde ise durum şu şekildedir: Örneğin sayilar1 adında bir değişken tanımladığımızda (A olsun)
             * bunu stack de yapmış oluyoruz. New dediğimiz anda sayilar1 için heap de yeni bir alan oluşturuyoruz ve
             * değerleri oraya atıyoruz. Sayilar2 yi tanımladığımızda (B olsun) da aynı şey geçerlidir. Bellekte sayilar2 için
             * heap de yeni bir alan oluşturmuş oluruz. sayilar 1 = sayilar2 dediğimizde
             * aslında sayilar1'in referans numarası sayilar2'nin referans numarasına eşittir demiş oluyoruz. yani A dediğimiz bellekte artık
             * B'nin alanını göstermiş oluyor. B hala aynı alanı gösteriyor. Sonrasında sayilar2[0]'ı  999 ' a atıyoruz.  
             */
        }
    }
}


