﻿using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "enis", "burak", "izmo", "can" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "hakan";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "enis", "burak", "izmo", "can" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("hakan");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            


        }
    }
}
