using System;

namespace hypotenusedasar{
    class dasar{
        static void Main(string[] args){

            //cara ribet 
            Console.WriteLine("\n\tMenghitung Hypotenuse Dasar");
            
            Console.WriteLine("\nBerapa panjang sisi a: ");
            double sisia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Berapa panjang sisi b: ");
            double sisib = Convert.ToDouble(Console.ReadLine());

            double aa = Math.Pow(sisia, 2);
            double bb = Math.Pow(sisib, 2);

            double ab = aa + bb;
            double z = Math.Sqrt(ab);

            Console.WriteLine("Hasil hypotenuse: "+ z);

            //cara simple

            Console.WriteLine("\nBerapa panjang sisi 1 : ");
            double sisi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Berapa Panjang sisi 2: ");
            double sisi2 = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt ((sisi1*sisi1)+(sisi2*sisi2));

            Console.WriteLine("Hypotenuse: "+c);


            Console.ReadKey();
        }
    }
}