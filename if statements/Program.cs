using System;

namespace ifdasar{
    class dasar {
        static void Main(string[] args){

            Console.WriteLine("Tolong ketikan nama anda : ");
            string input = Console.ReadLine();

            if (input == "")
            {
                Console.WriteLine("Anda Tidak mengetik Nama Anda!!");
            }
            else {
                Console.WriteLine("hai "+input);
            }

            // contoh 2
            //if (input != "")
            //{
              //  Console.WriteLine("Hai "+input);
            
           // }
           // else 
            //{
           //     Console.WriteLine("anda Tidak mengetik Nama Anda!!");
           // }

        }
    }
}