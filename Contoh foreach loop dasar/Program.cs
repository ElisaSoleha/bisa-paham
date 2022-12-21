using System;

namespace contohpenggunaanforeachloop{
    class dasar{
        static void Main(string[] args){
            
            string[] mars = {"planet", "mungkin","planet"};

            // mars[0] = "hallo";

            // for(int i = 0; i < mars.Length; i++){
                // Console.WriteLine(mars[i]);
            // }

            foreach (string mar in mars){
                Console.WriteLine(mar);
            }

              

            Console.ReadKey();
        }
    }
}