class Program
{
    static void Main(string[] args)
    {
        string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java" , "Python" , "C#" };
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(kurslar[i]);
        }
    //Foreach, dizi temelli yapıları tek tek dolaşmayı sağlıyor.
        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }
        Console.WriteLine("Sayfa Sonu - footer");
      
        {
            
        }
    }
}

