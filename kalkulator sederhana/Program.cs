using System;

namespace nama{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.WriteLine("Membuat Kalkulator Sederhana");
            Console.WriteLine("Anda Ingin menambah/mengkali/membagi/mengurangi");
            string jawaban = Console.ReadLine();
            if (jawaban == "menambah")
            {
                Console.WriteLine("Masukkan angka : ");
                double nambah = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Masukkan angka : ");
                double nambah2 = Convert.ToDouble(Console.ReadLine());
                double tambah = nambah+nambah2;
                Console.Write("Hasil: "+tambah);   
            }
            else if (jawaban == "mengkali")
            {
                
                Console.WriteLine("Masukkan angka : ");
                double nambah = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Masukkan angka : ");
                double nambah2 = Convert.ToDouble(Console.ReadLine());
                double tambah = nambah*nambah2;
                Console.Write("Hasil: "+tambah);   
            }
            else if(jawaban == "membagi"){
                 Console.WriteLine("Masukkan angka : ");
                double nambah = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Masukkan angka : ");
                double nambah2 = Convert.ToDouble(Console.ReadLine());
                double tambah = nambah/nambah2;
                Console.Write("Hasil: "+tambah);   
            }
            else if (jawaban == "mengurangi"){
                 Console.WriteLine("Masukkan angka : ");
                double nambah = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Masukkan angka : ");
                double nambah2 = Convert.ToDouble(Console.ReadLine());
                double tambah = nambah-nambah2;
                Console.Write("Hasil: "+tambah);   
            }
            
        }
    }
}