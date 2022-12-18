using System;
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


        

            Console.ReadKey();
        }
    }
}