using System;

namespace loopcabangdasar{
    class Dasar{
        static void Main(string[] args){


            Console.Write("Berapa banyak baris?: ");
            int baris = Convert.ToInt32(Console.ReadLine());

            Console.Write("Berapa banyak kolom?: ");
            int kolom = Convert.ToInt32(Console.ReadLine());

            Console.Write("Apa simbolnya: ");
            string simbol = Console.ReadLine();

            for (int i = 0; i < baris; i++){

                for (int j = 0; j < kolom; j++)
                {
                    Console.Write(simbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}