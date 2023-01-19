using System;
namespace mana
{
    class Program
    {
        static void Main(string[] args)
        {
            int b= 0;
            while(b<10)
            {
                
                if (b==6)
                {
                    b++;
                  continue;
               
                }
                Console.WriteLine(b);
                b++;
            } 
            int c=0;
            while(c<20){
                Console.WriteLine(c);
                c++;
                if(c==15)
                {
                    break;
                }
            }
        
            for (int i = 0; i < 6; i++)
            {

                if(i==4)
                {
                    break;
                }
                Console.WriteLine(i);
                
            }
            for (int i = 0; i < 7; i++)
            {
                if (i==5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        } 
    }
}