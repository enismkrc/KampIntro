﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //enis makaracı
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "enis";
            musteri1.Soyadi = "makaracı";
            musteri1.TcNo = "123123123";

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "987654";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";

            //gerçek müsteri- tüzel müşteri
            //SO'L'ID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
