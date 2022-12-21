using System;

namespace kondisioperator{
    class dasar{
        static void Main(String[] args){
            // operator kondisi = digunakan dalam penugasan bersyarat
            //  jika suatu kondisi benar/ salah

            double kondisi = 20;
            // string pesan;
            // cara 1
            // if (kondisi >= 15){
            //    pesan ="Diluar sedang hangat";
            // }
            // else {
                // pesan = "Diluar sedang hujan";
            // }
            // Console.WriteLine(pesan);

            // Cara 2 
            // pesan = (kondisi >=15)? "Diluar sedang hangat" : "Diluar sedang hujan";
            // Console.WriteLine(pesan);

            // cara 3
            Console.WriteLine((kondisi >= 15)? "Diluar hangat" : "Diluar hujan");





            Console.ReadKey();
        }
    }
}