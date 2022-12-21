using System;

namespace Gametebakangka{
    class Dasar{
        static void Main(string [] args){

            bool mainlagi = true;
            string lagi;

            while (mainlagi){
                Console.WriteLine("Tebak Angka dari 1 - 100 : ");
                int tebak = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Jawaban Anda : "+tebak);

                if(tebak == 50){

                    Console.WriteLine("Selamat tebakan anda benar");
                    Console.WriteLine("Apakah anda ingin bermain lagi (y/n)");
                    lagi = Convert.ToString (Console.ReadLine());

                    if (lagi == "y"){
                        mainlagi = true;
                    }
                    else {
                        mainlagi = false;
                        Console.WriteLine("Terima Kasih sudah bermain!!!\n");
                    }
                }
                else if (tebak > 50){
                    Console.WriteLine("Tebakan Anda Terlalu Tinggi!!\n");
                }
                else if(tebak < 50){
                    Console.WriteLine("Tebakan Anda Terlalu rendah!!\n");
                }
            // #carilah jalan pintas supaya tidak sulit.
            }

            Console.ReadKey();
        }
    }
} 