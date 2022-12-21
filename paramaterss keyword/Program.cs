using System;

namespace naman{
    class dasar{
        static void Main(string[] args){
            double  kangkung = bayam (2,3);

            Console.WriteLine(kangkung);
        }
        static double bayam(params double[] barus){
            double kangkung = 0;
            foreach(double baru in barus){
                kangkung += baru;

            }
            return kangkung;
        }
    }
}