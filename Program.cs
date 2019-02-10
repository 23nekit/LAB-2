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
            Console.Write("Введiть кiлькiсть рядкiв та стовпчикiв :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            array = ArrayRandom(array);
            Console.WriteLine("Початковий масив :");
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" {0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
            for(int i = 0; i < array.GetLength(0); i++)
            {
                int t = array[i,i];
                array[i, i] = array[i, array.GetLength(0) - 1 - i];
                array[i, array.GetLength(0) - 1 - i] = t;
            }
            Console.WriteLine("Перетворений масив :");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" {0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
