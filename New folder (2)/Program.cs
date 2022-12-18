using System;

namespace konstan
{
    class Program
    {
        static void Main(string[] args){
         //konstanta = nilai kebal yang diketahui pada waktu kompilasi
         // dan tidak berubah selama masa hidup program


         //example
         double pi = 3.1415;
         pi = 230;

        

         Console.WriteLine(pi);

         // if use const

         const double pie = 3.1415;
         
         Console.WriteLine(pie);



            Console.ReadKey();
        }
    }
}