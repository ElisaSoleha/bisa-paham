using System;

namespace methodstringdasar{
    class dasar
    {
        static void Main(string[] args)
        {
            string namalengkap = "Ba el";
            string hpnomer = "0822-4456-7894";
            
            namalengkap = namalengkap.ToUpper();// ToUpper digunakan untuk mengkapital kan huruf
            Console.WriteLine(namalengkap);

            namalengkap = namalengkap.ToLower(); //ToLower digunakan untuk mengecilkan huruf
            Console.WriteLine(namalengkap);

            hpnomer = hpnomer.Replace("-",""); // Replace digunakann untuk mengganti 
            Console.WriteLine(hpnomer);

            namalengkap = namalengkap.Insert(0, "@");
            Console.WriteLine(namalengkap);

            Console.WriteLine(namalengkap.Length);

            string namaawal = namalengkap.Substring (0, 3);
            string namaakhir = namalengkap.Substring (4, 2);
            Console.WriteLine(namaawal);
            Console.WriteLine(namaakhir);






            Console.ReadKey();
        }
    }
}