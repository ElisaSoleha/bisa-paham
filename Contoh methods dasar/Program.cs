using System;

namespace  contohmethods{
    class dasar{
        static void Main(string[] args){

            // method = melakukan bagian kode, setiap kali disebut 
            // "dipanggil". manfaat = 
            // gunakan kembali kode tanpa menulisnya berkali-kali

            string tigaempat = "SIAP";
            
            int no = 123;

            contohdasar(tigaempat, no);
            // contohdasar();
            // contohdasar();
            // contohdasar();
            

            Console.ReadKey();
        }static void contohdasar(string tigaempat, int no){

            Console.WriteLine("Selamat menikmati liburan");
            Console.WriteLine("Kamu sudah berusaha, cobalah terima apapun hasilnya.");
            Console.WriteLine("setidaknya kamu ada usaha untuk melakukannya.");
            Console.WriteLine(+no+" KEEP SMILE...... "+tigaempat);
            Console.WriteLine();

        }
    }
}