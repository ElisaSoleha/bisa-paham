using System;

namespace mathdasar{
    class dasar{
        static void Main (string[] args){
            
            double x = 4; 
            double y = 3.14;
            double z = 4.99;
            double m = -2;

            double a = Math.Pow(x, 2); //digunakan untuk perpangkatan
            double b = Math.Sqrt(x);  // digunakan untuk akar
            double c = Math.Abs(m); // digunakan untuk mempositif kan angka negatif
            double d = Math.Round (y); //digunakan untuk membulatkan bilangan
            double e = Math.Ceiling(y); // digunakan untuk membulatkan bilangan keatas
            double f = Math.Floor(z); //digunakan untuk membulatkan bilangan 
            double g = Math.Max(x, y); // digunakan untuk mencari angka atau nilai tertinggi
            double h = Math.Min(x, y); // digunakan untuk mencari nilai terendah



            Console.WriteLine("Contoh 1: "+a);
            Console.WriteLine("Contoh 2: "+b);
            Console.WriteLine("Contoh 3: "+c);
            Console.WriteLine("Contoh 4: "+d);
            Console.WriteLine("Contoh 5: "+e);
            Console.WriteLine("Contoh 6: "+f);
            Console.WriteLine("Contoh 7: "+g);
            Console.WriteLine("Contoh 8: "+h);
            Console.ReadKey();
        }
    }
} 