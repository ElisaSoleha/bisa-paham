using System;

namespace contohparameterskeyword{
    class dasar{
        static void Main(string[] args){

            // Parameters Keyword adalah parameter metode yang mengambil
            //   sejumlah variabel argumen. 
            // tipe parameter harus array satu dimensi
            
            double ulang;

            ulang = KelasDasar(3.24, 23.4, 4);

            Console.WriteLine(ulang);
            


            Console.ReadKey();
        }
        static double KelasDasar(double a){
            return a;

        }
         static double KelasDasar(double a, double b){
            return a*b;

        } static double KelasDasar(double a, double b, double c){
            return a*b*c;

        }
         static double KelasDasar(double a, double b, double c, double d){
            return a*b*c;

        }
         static double KelasDasar(double a, double b, double c, double d, double e){
            return a*b*c;

        } static double KelasDasar(double a, double b, double c, double d, double e, double f){
            return a*b*c;

        } static double KelasDasar(double a, double b, double c, double d, double e, double f, double g){
            return a*b*c;

        }
    }
}