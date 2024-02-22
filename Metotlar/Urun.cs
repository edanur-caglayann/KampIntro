using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Urun
    {
        //Property - Özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

        /* AÇIKLAMA 2- Eğer class sınıfına yeni bir özellik eklersek
        çağırdığımız diğer yerlerde tek tek düzeltmemize gerek kalmayacak.
        çünkü bunlar ürünün özellikleri ve ürün sınıfını çağırdığımızda
        içindeki her şeyi biz ekleyip kullanabiliriz.
          (ENCAPSULATİON)
        */
    }
}
