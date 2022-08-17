using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori"; //type safety
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            //if (dolarDun>dolarBugun)
            //{
            //    Console.WriteLine("Azalış oku");
            //}
            //else if (true)
            //{
            //    Console.WriteLine("Artış oku");
            //}
            //else
            //{
            //    Console.WriteLine("Değişmedi oku");
            //}

            // Ternary operatörü if else bloğunu tek satırda kullanmanı sağlar.Dönecek değerler aynı türde olmalıdır.

            string kurDurumu = dolarDun > dolarBugun ? "Azalış oku" : (dolarBugun>dolarDun ? "Artış oku" : "Değişmedi");//ikiden fazla değişkenli ternary kullanımı


            //if (sistemeGirisYapmisMi == true)
            //{
            //    Console.WriteLine("Kullanıcı ayarları buttonu");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yap butonu");
            //}
            string mesaj = sistemeGirisYapmisMi==true ? "Kullanıcı ayarları buttonu" : "Giriş yap butonu"; //ternary örneği
            Console.WriteLine(kurDurumu);

        }
    }
}
