using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);     
        }

        /* AÇIKLAMA 1- Eğer aşağıdaki örnekte olsuğu gibi parametre alan bir metot oluşturursak
         * ekstra bir parametre daha alsın dediğimizde diğer sayfalarda,
         * metodu çalıştırdığımız yerlerde hata verir. Örneğin stok adedini sonradan
         * eklersek, metodu çalıştırdığımız yerlerde hata verecek ve tek tek
         * stok adedi bilgisini girmemizi isteyecek.
         */
        public void EkleAlternatif(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {

        }
    }

}
