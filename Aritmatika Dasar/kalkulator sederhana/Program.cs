using System;

namespace kalkulatordasar{
    class Dasar {
        static void Main (string[] args){

            double hasil;
            bool angka = true;
            while (angka == true){

                Console.Write("Masukkan Angka 1 : ");
                double angka1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Angka 2: ");
                double angka2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Pilih opsi dibawah ini: ");
                Console.WriteLine("+ : Tambah");
                Console.WriteLine("- : kurang");
                Console.WriteLine("* : Perkalian");
                Console.WriteLine("/ : Pembagian");
                Console.Write("Enter:  ");


                switch (Console.ReadLine()){

                    case "+": 
                    hasil = angka1 + angka2;
                    Console.WriteLine("Hasil tambah Anda : "+hasil);
                    break;
                    case "-": 
                    hasil = angka1-angka2;
                    Console.WriteLine("Hasil dari Pengurangan Anda: "+hasil);
                    break;
                    case "*": 
                    hasil = angka1*angka2;
                    Console.WriteLine("Hasil dari Perkalian Anda: "+hasil);
                    break;
                    case "/": 
                    hasil = angka1/angka2;
                    Console.WriteLine("Hasil dari Pembagian Anda: "+hasil);
                    break;
                    default:
                    Console.WriteLine("Anda tidak memilih opsi, tidak ada jawaban.");
                    break;

                }

                Console.WriteLine("Anda ingin melanjut pencarian?(y/n)");
                string lanjut = Console.ReadLine();
                
                if (lanjut == "y"){
                    angka = true;
                }
                else {
                    angka = false;
                }
            }
        }
    }
}