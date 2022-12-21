using System;

namespace methodsoverloadingcontoh
{
    class dasar
    {
        static void Main(string[] args){

            // method overloading adalah metode berbagi nama yang sama,
            //  tetapi parameter berbeda. nama + parameter = tanda tangan,
            //  metode harus memiliki tanda tangan yang unik
           
            double asal;

            asal = kelasdasar(4, 5, 4);

            Console.WriteLine (asal);

            Console.ReadKey();
        }
        static double kelasdasar(double m, double n){
            return m + n ;
        }
        static double kelasdasar(double m, double n, double d){
            return m + n +d;
        }// BRO CODE
    }
}