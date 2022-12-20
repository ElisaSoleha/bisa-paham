using System;

namespace whileloopdasar{
    class Pengenalanwhilellopdasar{
        static void Main(string[] args){

            // while loop digunakan untuk melakukan pengulangan
            // selama kondisi belum dinyatkan benar, jika kondisi sudah benar
            //maka pengulangan akan berhenti

           string sudah = "";

            while (sudah == "")
            {
                Console.WriteLine("udah makankah?");
                sudah = Console.ReadLine();

                if(sudah == "udah"){
                    Console.WriteLine("Baiklah kalau udah");
                }
                else if (sudah == "belum"){
                    Console.WriteLine("Loh Loh kok belum");
                    break;
                }
               

            }
             Console.WriteLine("oke");
           

            Console.ReadKey();
        }
    }
}