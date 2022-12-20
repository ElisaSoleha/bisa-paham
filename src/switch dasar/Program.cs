using System;

namespace switchdasar
{
    class Pengenalamswitch
    {
        static void Main(string[] args){
            Console.WriteLine("Hari apa ujian?");
            string hari = Console.ReadLine();

            switch(hari)
            {
                case "senin":
                Console.WriteLine("Hari senin tidak ada ujian");
                break;
                case "selasa":
                Console.WriteLine("Hari selasa tidak ada ujian");
                break;
                case "rabu":
                Console.WriteLine("Hari Rabu tidak ada ujian");
                break;
                case "kamis":
                Console.WriteLine("Hari kamis tidak ada ujian");
                break;
                case "jumaat":
                Console.WriteLine("Hari jumaat tidak ada ujian");
                break;
                case "sabtu":
                Console.WriteLine("YA hari sabtu ujian");
                break;
                case "minggu":
                Console.WriteLine("Hari minggu tidak ada ujian");
                break;
                default:
                Console.WriteLine($"{hari} itu bukan nama hari!!");
                break;

            }
            Console.ReadKey();
        }
    }
}