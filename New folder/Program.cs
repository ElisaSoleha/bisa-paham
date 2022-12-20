using System;

namespace Tebakkata
{
    class Tebak
    {
        static void Main(string[] args)
        {
            int Kodea;
            int kodeb;
            int dikalikan;
            int dijumlahkan;
            int jumlahtebakan;
            string tebakan1;
            string tebakan2;

            Kodea = 4;
            kodeb = 3;

            jumlahtebakan = 2;

            dikalikan = Kodea*kodeb;
            dijumlahkan = Kodea+kodeb;


            Console.WriteLine("Welcome to Game Tebak angka");
            Console.WriteLine("Jadi angka yang anda tebak berjumlah " +jumlahtebakan);
            Console.WriteLine("Jika angka tersebut dijumlahkan maka hasilnya " +dijumlahkan);
            Console.WriteLine("dan jika angka tersebut dikalikan maka hasilnya " +dikalikan);


            Console.Write("Masukkan tebakank ke-1 anda : ");
            tebakan1 = Console.ReadLine();
            Console.Write("Masukkan tebakan ke-2 anda : ");
            tebakan2 = Console.ReadLine();

            Console.WriteLine("Tebakan anda : "+tebakan1+" "+tebakan2);

            if(tebakan1 == Kodea.ToString() && tebakan2 == kodeb.ToString())
            {
                Console.WriteLine("selamat tebakan anda benar!!!");
            }else{
                Console.WriteLine("sayang sekali, tebakan anda salah");
            }

        }
    }
}
