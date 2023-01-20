using System;

namespace returnkeyworddasar{
    class dasar{
        static void Main(string[] args){
            //return adalah mengembalikan data kembali ke 
            // tempat di mana metode dipanggil

            double x;
            double y;
            double kembali;

            Console.WriteLine("Enter nomor 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter nomor 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            kembali = contohdasar(x, y);

            Console.WriteLine(kembali);


            Console.ReadKey();
        }
        static double contohdasar(double x, double y){
            //double z = x*y;
            //return z;
            return x*y;
        }
        
    }
}