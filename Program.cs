using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProgram6
{
    class Program
    {
        static int[][] ArrayRandom(int[][] array)
        {
            Console.Write("Дiапазон рандому вiд :");
            int from = Convert.ToInt32(Console.ReadLine());
            Console.Write("Дiапазон рандому до :");
            int to = Convert.ToInt32(Console.ReadLine());
            Random RndGen = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[0].Length; j++)
                {
                    array[i][j] = RndGen.Next(from, to + 1);
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
            int[][] array = new int[nrows][];
            int maxelement;
            int imaxelement;
            for(int i = 0; i < nrows; i++)
            {
                array[i] = new int[ncolumns];
            }
            array = ArrayRandom(array);
            Console.WriteLine("Початковий масив :");
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[0].Length; j++)
                {
                    Console.Write(" {0,3}", array[i][j]);
                }
                Console.WriteLine();
            }
            maxelement = array[0][0];
            imaxelement = 0;
            for(int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] > maxelement)
                    {
                        maxelement = array[i][j];
                        imaxelement = i;
                    }
                }
            }
            for (int i = imaxelement; i < array.Length - 1; i++) 
            {
                int[] t = array[i];
                array[i] = array[i + 1];
                array[i + 1] = t;
            }
            Array.Resize(ref array, array.Length - 1);
            Console.WriteLine("Перетворений масив :");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[0].Length; j++)
                {
                    Console.Write(" {0,3}", array[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
