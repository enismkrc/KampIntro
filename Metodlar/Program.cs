using System;

namespace Metodlar
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
            urun1.Fİyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fİyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //urun-urun sayısı kadar döner x'de diyebiliriz takma isim zaten
            //type-safe - tip güvenliği
            foreach (var urun in urunler) //in urunler-urunleri tek tek gez 
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fİyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");

            }

            Console.WriteLine("------------Metotlar-------------");
            //instance - örnek
            //encapsulation - kapsülleme

            SepetManager sepetManager = new SepetManager();
            
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "yeşil", 12, 10);
            sepetManager.Ekle2("Elma", "yeşil elma", 12,9);
            sepetManager.Ekle2("karpuz", "dy karpuzu", 12,8);







        }
    }
}



//dont repeat yourself - DRY - Clean Code - Best Practice