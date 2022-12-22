using System;

namespace penggantiifawitch
{
    class Program
    {
        static void Main(string [] args)
        {
             Console.WriteLine("Hanya 5 orang yang dizinkan masuk.");
              Console.Write("Kamu nomer yang keberapa?");
              int orang = Convert.ToInt32(Console.ReadLine());

              switch(orang)
              {
                case 1:
                    Console.WriteLine("Silahkan Masuk.");
                    break;
                case 2:
                    Console.WriteLine("Silagkan masuk");
                    break;
                case 3:
                    Console.WriteLine ("Silahkan masuk");
                    break;
                case 4:
                     Console.WriteLine("Silahkan Masuk");
                     break;
                case 5 :
                    Console.WriteLine("Silahkan masuk");
                    break;
                default :
                    Console.WriteLine("Anda TIdak boleh masuk");
                    break;
              }
        }
    }
}