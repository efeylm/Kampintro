using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
          {

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs", "Java","Python"};
            
            //for (int i = 0; i <kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}
            
            //Console.WriteLine("***For bitti***");
            
            //foreach (string kurs in kurslar) //dizi temelli yapıları tek tek döner
            //{
            //    Console.WriteLine(kurs);
            //}
            
            int sayi = 0;
            while (sayi<kurslar.Length)
            {
                Console.WriteLine(kurslar[sayi]);
                sayi++;
            }
        
        }
    }
}
