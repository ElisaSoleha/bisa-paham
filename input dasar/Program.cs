using System;

namespace inputuser
{
    class User
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siapa Nama Kamu ?");
            string name = Console.ReadLine();

            Console.WriteLine("Umur kamu berapa?");
            int umur = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Hello "+ name);
            Console.WriteLine($"Kamu berumur {umur} tahun");

            Console.ReadKey();
        }
    }
}