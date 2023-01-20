using System;

namespace latihan1
{
    class dasar
    {
        static void Main(string[]args)
        {
            // string[] makanan = {"sate", "lontong", "bakso"};
            // string[] minuman = {"Teh es", "susu", "Air putih"};
            // string[] cemilan = {"keripik hijau", "ring-ring" , "potato"};


            string [,] nama = {{"sate" ,"lontong" ,"bakso"},
            {"Teh es", "susu", "Air putih"},
            {"keripik hijau", "ring-ring" , "potato"}
            };

            nama[1,2] = "Kopi";
            nama[2,2]= "air hangat";

            // foreach (string kamu in nama){

            // Console.WriteLine (kamu);
            // }

            for (int i = 0; i < nama.GetLength (0);  i++){
                for (int m = 0; m < nama.GetLength(1); m++){
                    Console.Write(nama[i, m]+" ");
                }
                Console.WriteLine();
            }




            Console.ReadKey();
        }
    }
}