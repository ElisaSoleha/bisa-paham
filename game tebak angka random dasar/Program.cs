using System;

namespace Tebakangkaandom{
    class dasar {
        static void Main(string[] args){
            bool angka = true;
            Random dasar = new Random ();
            int tinggi = 100;
            int rendah = 1;
            

            while(angka == true){
                
                int nama = dasar.Next(rendah, tinggi + 1);
                int angka1 = 0;
                int pemain = 0;

                while (angka1 != nama){

                Console.WriteLine("Game tebak angka random: ");
                angka1 = Convert.ToInt32(Console.ReadLine());

                    if (angka1 > nama){

                        Console.WriteLine("tebakan anda terlalu tinggi");

                    }else if(angka1 < nama){

                        Console.WriteLine("Tebakan anda terlalu rendah");
                    }
                    pemain++;
                }
                Console.WriteLine("Tebakan Anda : "+angka1);
                Console.WriteLine("Anda Menang");
             


                Console.WriteLine("Anda mau bermain lagi (y/n)");
                string nama2 = Console.ReadLine();
                if (nama2 == "y"){
                    angka = true;
                }
                else {
                    angka = false;
                }
            }
            Console.ReadKey();
        }
    }
}