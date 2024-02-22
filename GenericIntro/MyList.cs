using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIntro
{
      class MyList<T>
    {
        T[] items; // T tipinde bir dizi tanımlanıyor. T, generic bir tip olup, kullanıcı tarafından belirlenebilir.
        
        public MyList() // Bu, sınıfın yapıcısıdır (constructor). Sınıf örneği oluşturulduğunda otomatik olarak çağrılır.
        {
            items = new T[0]; // items dizisi, boyutu 0 olan bir dizi olarak başlatılıyor.
        }
        public void Add(T item)
        {
            T[] tmpArray = items; // Geçici dizinin referansını items dizisinin referansına eşitledik
            items = new T[items.Length + 1]; // newlediğimiz de referansı değiştirmiş oluyoruz. Bu yüzden önce dizinin referansını geçici bir diziye tutturduk
            for (int i = 0; i < tmpArray.Length; i++) // Geçici dizideki tüm öğeleri yeni items dizisine kopyalıyoruz.
            {
                items[i] = tmpArray[i];
            }
            items[items.Length-1]=item; // Son olarak, yeni eklenen öğeyi items dizisinin sonuna ekliyoruz.
        }
    }
}
