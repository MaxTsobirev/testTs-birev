using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTsõbirev
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Sisestage klaviatuurilt suvalise pikkusega string ja arvutage stringi määratud märgi esinemise protsent.

            Console.WriteLine("Sisestage mis tahes pikkusega string:");
            string str = Console.ReadLine(); 
            Console.WriteLine("Sisestage märk, et leida selle esinemise protsent stringist: ");
            char sym = Console.ReadKey().KeyChar;
            Console.WriteLine();
            //переменные sym str

            int length = str.Length;
            char[] arr = str.ToCharArray();
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] == sym)
                {
                    counter++;
                }
            }
            double lengthDouble = Convert.ToDouble(length);
            double counterDouble = Convert.ToDouble(counter);
            double procent = (counterDouble / lengthDouble) * 100; //нахождение процента
            Console.WriteLine($"Sümboli {sym} esinemise protsent on {procent} %");
            Console.ReadLine();*/

            //Esitatud on reaalarvude massiiv mõõtmetega 10x10. Leidke iga rea ​​elementide summad, iga veeru elementide korrutis ja põhidiagonaali maksimaalne element (vihje: kõik elemendid, mille reanumber on sama kui veeru number).

            int[,] M = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = random.Next(1, 50);
                    Console.Write(M[i, j] + " ");
                }
                Console.WriteLine();
            }
            int max = M[0, 0];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                double pr = 1;
                double sum = 0;
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    pr = pr * M[j, i];
                    sum = sum + M[i, j];
                    if (i == j)
                        if (max < M[i, j])
                            max = M[i, j];
                }
                Console.WriteLine("Korrutis " + (i + 1) + " veerg=" + pr);
                Console.WriteLine("Summ " + (i + 1) + " string=" + sum);
            }
            Console.WriteLine("Maksimaalne element diagonaalis " + max);
            
            Console.ReadLine();*/
        }
    }
}
