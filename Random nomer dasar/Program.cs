using System;

namespace RandomDasar
{
    class Randoom{
        static void Main(string[] args){

           Random random = new Random();

           int dasar = random.Next(1,10);
           int dasar1 = random.Next(1,10);
           int dasar2 = random.Next(1,10);



           Console.WriteLine(dasar); 
           Console.WriteLine(dasar1); 
           Console.WriteLine(dasar2); 




            Console.ReadKey();
        }
    }
}