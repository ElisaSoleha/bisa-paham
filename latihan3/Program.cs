using System;
using System.Collections.Generic;
using System.Text;

namespace Latihan2objek {
    class dasar
    {
        static void Main(string[] args)
        {
            kegiatan baru = new kegiatan();
            baru.nama = "kill";
            baru.umur = 9;

            kegiatan baru1 = new kegiatan();
            baru1.nama = "sminn";
            baru1.umur = 9;
            
            baru1.makan();
            baru1.tidur();
            
            baru.makan();
            baru.tidur();
            Console.ReadKey();

        }
    }
    class kegiatan{

        public string nama;
        public int umur;
        public void makan(){
            Console.WriteLine($"{nama} sudah makan ");
        }
        public void tidur(){
            Console.WriteLine($"{nama} sedang tidur");
        }
    }

}