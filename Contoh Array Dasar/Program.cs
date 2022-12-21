using System;

namespace contohoenggunaanarraydasar{
    class Dasar{
        static void Main(string[] args){

            // string[] cars = {"mbr", "musang", "king"};

            string[] cars = new string [3];

            cars[0] = "if you never try how you know";
            cars[1] = "musang";
            cars[2] = "king";

            // Console.WriteLine(cars); output = System.String[]

            // Console.WriteLine(cars[0]); putput = mbr
            // Console.WriteLine(cars[1]); output = musang
            // Console.WriteLine(cars[2]); output = king

            for (int i = 0; i < cars.Length; i++){
                Console.WriteLine(cars[i]);
            }



            Console.ReadKey();
        }
    }
}