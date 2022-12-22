using System;
    namespace anma
    { 
        class Program{
            static void Main(string[] args)
            {
                
                Console.WriteLine("Program Gaji Karyawan");
                Console.WriteLine("-------------------------");

                Console.Write("Nik : ");
                Console.ReadLine();
                Console.Write("Nama Karyawan: ");
                Console.ReadLine();
                Console.Write("Gaji Pokok: ");
                int pokok = Convert.ToInt32(Console.ReadLine());
                Console.Write("Tunjangan Jabatan: ");
                int jabatan = Convert.ToInt32 (Console.ReadLine());
                Console.Write("Tunjangan Istri: ");
                int istri =Convert.ToInt32(Console.ReadLine());
                Console.Write("Tunjangan Anak: ");
                int anak =Convert.ToInt32(Console.ReadLine());
                Console.Write("Potongan: ");
                int potongan = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Console.Write($"Gaji Bersih = RP {pokok+jabatan+istri+anak-potongan} Rupiah");
            }
        }
        
    }
