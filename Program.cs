using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProgram6
{
    class Program
    {
        static int[,] ArrayRandom(int[,] array)
        {
            Console.Write("Дiапазон рандому вiд :");
            int from = Convert.ToInt32(Console.ReadLine());
            Console.Write("Дiапазон рандому до :");
            int to = Convert.ToInt32(Console.ReadLine());
            Random RndGen = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                {
                    array[i,j] = RndGen.Next(from, to + 1);
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть рядкiв :");
            int nrows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть кiлькiсть стовпчикiв :");
            int ncolumns = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[nrows, ncolumns];
            bool nozero = true;
            int c = 0;
            int product = 1;
            array = ArrayRandom(array);
            Console.WriteLine("Ваш масив :");
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" {0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
            for(int i = 0; i < array.GetLength(1); i++)
            {
                for(int j = 0; j < array.GetLength(0); j++)
                {
                    if (array[j, i] == 0)
                    {
                        nozero = false;
                        break;
                    }
                }
                if (nozero)
                {
                    for(int j = 0; j < array.GetLength(0); j++)
                    {
                        product *= array[j, i];
                    }
                    Console.WriteLine("Добуток елементiв у {0} стовпчику масиву :{1}",c + 1,product);
                    product = 1;
                }
                nozero = true;
                c += 1;
            }
            Console.ReadKey();
        }
    }
}
