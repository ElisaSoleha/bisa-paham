using System;
<<<<<<< HEAD
namespace bisaaa{
    class Program{
        static void Main(string[] args){
          
          int x; //declaration
          x = 123; // initialization

          int y = 321; // declaration + initialization

          int z = x + y;

          int age = 21; // wh0le integer

          double height = 175.5; // desimal number
          bool alive = false;
          char symbol = '@';
          string name = "bael";

          Console.WriteLine("Hello " + name );
          Console.WriteLine("Your age is: " +  age);
          Console.WriteLine("Your heinght is: " +height+"cm");
          Console.WriteLine("Are you alive?" +alive);
          Console.WriteLine("Ypur simbol is : " +symbol);

          string userName = symbol + name ;

          Console.WriteLine("Your user name is : " +userName  );


        

=======

namespace konstan
{
    class Program
    {
        static void Main(string[] args){
         //konstanta = nilai kebal yang diketahui pada waktu kompilasi
         // dan tidak berubah selama masa hidup program


         //example
         double pi = 3.1415;
         pi = 230;

        

         Console.WriteLine(pi);

         // if use const

         const double pie = 3.1415;
         
         Console.WriteLine(pie);



>>>>>>> coba-fitur1
            Console.ReadKey();
        }
    }
}