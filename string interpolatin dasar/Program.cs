using System;

namespace stringinterpolation
{
    class Dasar
    {
        static void Main(string[] args)
        {
            // string interpolation = memungkinkan kita untuk menyisipkan
            //  variabel ke dalam precode literal string
            //  sebuah literal string dengan $ {} adalah placeholder

            string bedak = "bedak baby";
            string deodoran = "rezona";
            int jumlah = 2;
            // cara biasa
            // Console.WriteLine("Saya mau membeli "+bedak+" dan "+deodoran);
            // Console.WriteLine("Masing-masing "+jumlah+" dari benda itu");

            // cara string interpolatioon 
            Console.WriteLine($"Saya mau membeli {bedak} dan {deodoran}");
            Console.WriteLine($"Masing-masing {jumlah} dari benda itu");


            
            Console.ReadKey();
        }
    }
}