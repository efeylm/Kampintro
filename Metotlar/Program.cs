using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            //Urun[] urunler = new Urun[] {urun1,urun2};
            //foreach (Urun urun in urunler)
            //{
            //    Console.WriteLine(urun.Adi);
            //    Console.WriteLine(urun.Aciklama);
            //    Console.WriteLine(urun.Fiyati);
            //    Console.WriteLine("---------------------");
            //}

            Console.WriteLine("-----Metotlar-----");

            //instance class örneği oluşturma
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10); // bu şekilde yaparsan yeni parametre eklediğinde hepsini değiştirmek zorunda kalırsın
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);


        }
    }
}