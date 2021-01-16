using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
               // type safety=tip güvenliği
               //do not repeat yourself=kendini tekrarlama
               //değer tutucu , alias
            string kategoriEtiketi = "kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("değişmedi butonu");
            }
            else
            {
                Console.WriteLine("artış butonu");
            }


            //if 2 kere taba bas bloku oto yapıyo
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            


        }
    }
}
