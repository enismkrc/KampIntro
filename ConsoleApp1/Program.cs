using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Monitor1 = new Product();
            Monitor1.Marka = "LG";
            Monitor1.Inch = 27;
            Monitor1.Fiyat = 3149;

            Product Monitor2 = new Product();
            Monitor2.Marka = "MSI";
            Monitor2.Inch = 31.5;
            Monitor2.Fiyat = 2822;

            Product Monitor3 = new Product();
            Monitor3.Marka = "James Donkey";
            Monitor3.Inch = 27;
            Monitor3.Fiyat = 1599;


            Product[] monitorler = new Product[] { Monitor1, Monitor2, Monitor3 };


            //for ile sıralama

            for (int i = 0; i < monitorler.Length; i++)
            {
                Console.WriteLine(monitorler[i].Marka + ":"  + monitorler[i].Inch + ":" + monitorler[i].Fiyat + ":");
            }
        }
    }

    class Product
    {
        public string Marka { get; set; }
        public double Inch { get; set; }
        public int Fiyat { get; set; }
    }
}
