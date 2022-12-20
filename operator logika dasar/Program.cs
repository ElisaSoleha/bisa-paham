using System;

namespace logikadasar
{
    class PengenalanLogikadasar{
        static void Main(string[] args){
            
            Console.WriteLine("Nilai ujian mu?");
            int nilai = Convert.ToInt32(Console.ReadLine());

        if(nilai >= 70 && nilai <= 100)
        {
            Console.WriteLine("its good, Congratulation!!");

        }
        else if(nilai >= 50 || nilai <= 50)
        {
            Console.WriteLine("Damn, Beelajaaarrrr!!!!");
        }
        }
    }
}