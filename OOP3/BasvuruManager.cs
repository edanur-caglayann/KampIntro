using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        // Başvuruyu hangi krediye göre yapılacağını belirlemek için
        // herkesin referansını tutanı seçeriz.
        // Bu sayede buraya istediğimiz krediyi yollayabiliriz.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log(); 
            /* Parametre olarak ne gönderirsek bellekte onun referansı 
             * çalışır. Örneğin parametre olarak ihtiyaç Kredisi yollarsak
             * onun bellekteki referansı çalışır ve onun Kredisi hesaplanır.
             */
        }
        /* Müşteriye göre kredilerin durumları hesaplanacak olsun. x tane kredi türünün
         * hepsinin hesaplanmış halini istiyoruz. Bu durumda x tane aynı türden veriyi bir
         * arada tutmak için liste yapısı kullanırız.
         * IKrediManager türünde bir liste oluşturmuş olduk.
         */
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
