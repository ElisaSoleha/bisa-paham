using System;

namespace contohmultiarray{
    class Dasar
    {
        static void Main(string [] args)
        {
            string[] blackpink = {"Jisoo", "Jennie", "Rose", "Lalisa"};
            string[] Redvelved = {"irene", "wendy", "seulgi", "hyerin"};
            string[] exo = {"Luhan", "sehun", "kai", "DO"};

            string [,] gabungan = { {"Jisoo", "Jennie", "Rose", "Lalisa"},
                                    {"irene", "wendy", "seulgi", "hyerin"},
                                    {"Luhan", "sehun", "kai", "DO"} 
                                    };
            gabungan[0, 2] = "Rose jisoo";
            gabungan[2, 0] = "irenee";

            /*foreach (string gabung in gabungan){
                Console.WriteLine(gabung);
            }*/

            for (int i = 0; i < gabungan.GetLength(0); i++ ){
                for (int m = 0; m < gabungan.GetLength(1); m++ ){
                    Console.Write(gabungan[i, m] + " ");
            }
            Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}