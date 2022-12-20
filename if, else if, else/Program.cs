using System;
namespace iiii{

class Program {
 
    
    static void Main(string [] args )
    {
        kamu();
        aku();
        tidaksatu();
        setiadalamdiam();
        

        Console.WriteLine("3*3*3 = ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num == 27)
        {
            Console.WriteLine("anda Benar");
        }else if ( num != 27)
        {
            Console.WriteLine("Anda salah");
        }

        Console.WriteLine("6+6+1 = ");
        int num1 = Convert.ToInt32 ( Console.ReadLine());

        if (num1 == 13)
        {
            Console.WriteLine("anda Benar");
        }else if ( num1 != 13)
        {
            Console.WriteLine("Anda salah");
        }

        Console.WriteLine("(1+8+9)/9 = ");
        int num3 = Convert.ToInt32 (Console.ReadLine());

        if (num3 == 2)
        {
            Console.WriteLine("anda Benar");
        }else if ( num3 != 2)
        {
            Console.WriteLine("Anda salah");
        }

    }static void kamu()
    {
           Console.WriteLine("Tebak angka dari 1-100 : ");
                int angka = 80;
                angka = Convert.ToInt32(Console.ReadLine());
                
                    
             
                if (angka < 80 )
                {
                    Console.WriteLine("salah tebakan anda terlalu Rendah.");
                
                }else if (angka > 80 )
                {
                    Console.WriteLine("Salah angka terlalu tinggi ");

                }else 
                {
                    Console.WriteLine("Anda benar");
                    Console.WriteLine("bye..");
                }
                // nanti terakhir
                Console.ReadKey ();
          }
          static void aku()
          {
            
                Console.Title ="Usaha aja dulu hasilnya kan nanti";
                int nama = 80;

                for(int i = 0; i < 100; i++){

                     Console.Write("Tebak angka dari 1-100 : ");
                     nama = Convert.ToInt32(Console.ReadLine());

                    if (nama < 80)
                    {
                        Console.WriteLine("Salah, angka terlalu rendah");
                    }else if (nama > 80)
                    {
                        Console.WriteLine("Salah, angak terlalu tinggi");
                    }else if (nama == 80) {
                        Console.WriteLine("Anda benar");
                        Console.WriteLine("bye...");
                        break;
                      }  
                }
                

          }static void tidaksatu()
          {
            
                Console.WriteLine("1. Menghitung volume Kubus");
                Console.WriteLine("2. Menghitung luas lingkaran");
                Console.WriteLine("3. Menghitung Volume silinder");
                int bil2 = Convert.ToInt32(Console.ReadLine());

                if(bil2 == 1)
                {
                    
                    Console.Write("Masukkan Panjang sisi Kubus : ");
                    int Volume = Convert.ToInt32(Console.ReadLine());
                    Volume = Volume*Volume*Volume;
                    Console.WriteLine("Jadi Volume Kubus = "+Volume);
                    

                }else if (bil2 == 2)
                {   
                    double n = 3.14;
                    Console.Write("Masukkan Panjang jari-jari lingkaran : ");
                    double  jari = Convert.ToDouble (Console.ReadLine());
                    jari = (jari*jari)*n;

                    Console.WriteLine("Jadi Luas Lingkaran = "+jari);

                }else if (bil2 == 3){

                    double n = 3.14;
                    Console.Write("Masukkan panjang jari-jari : ");
                    double jari2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukan silinder : ");
                    double jari = Convert.ToDouble (Console.ReadLine());

                    jari = n*(jari2*jari2)*jari;
                    Console.WriteLine("Jadi Volume Silinder = "+jari);

                }else{
                    Console.WriteLine("Tejadi kesalahan pada inputan anda!!");
                }
          }static void setiadalamdiam()
          {
                      float D;

                Console.Write("Input a : ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Input b : ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Input c : ");
                float c = float.Parse(Console.ReadLine());

                D = (b*b)-4*a*c;    
                Console.WriteLine("Determinan : "+D);             

                if (D == 0)
                {
                    double x = Convert.ToDouble(Console.ReadLine());

                    x = Math.Sqrt( D);

                    x = b/2*a;

                    Console.WriteLine ("persamaan Kuadrat : "+x);

                }else if ( D> 0)
                {

                }else if (D < 0)
                {

                }
         
          }
    }       
}