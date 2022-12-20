using System;

namespace usahaajaduluhasilnyakannanti
{
        class oo
        {
            static void Main(string[] args)
            {
            for (int i = 0; i <100; i++){
               tenang();
                float hasil;
                
                Console.Write("Masukkan bilangan satu : ");
                float bil1 = float.Parse(Console.ReadLine());

                Console.Write("Masukkan bilangan dua  : ");
                float bil2 = float.Parse(Console.ReadLine());

                hasil = bil1 / bil2; 
                Console.WriteLine("Hasil = "+hasil);

                if(bil2 == 0)
                {
                    Console.WriteLine("Terjadi kesalahan pada input bilangan dua.");
                    break;
                }
            
            }
                Console.ReadKey();
            }static void tenang()
            {
                Console.WriteLine();
                Console.WriteLine("Menghitung");
                Console.Write("");

            }
        }
    }