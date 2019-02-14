using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void ArrayWrite(int[] array)
        {
            Console.WriteLine("Ваш масив :" + string.Join(" ", array));
        }
        static void ArrayEdit(int[] array)
        {
            Console.Write("Введіть ключ :");
            int key = Convert.ToInt32(Console.ReadLine());
            int ikey = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    ikey = i;
                    break;
                }
            }
            if (ikey != -1)
            {
                for (int i = ikey; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                Array.Resize(ref array, array.Length - 1);
            }
        }
        static int[] ArrayRandom(int n)
        {
            Console.Write("Дiапазон рандому вiд :");
            int from = Convert.ToInt32(Console.ReadLine());
            Console.Write("Дiапазон рандому до :");
            int to = Convert.ToInt32(Console.ReadLine());
            int[] arrayrandom = new int[n];
            Random RndGen = new Random();
            for (int i = 0; i < arrayrandom.Length; i++)
            {
                arrayrandom[i] = RndGen.Next(from, to + 1);
            }
            return arrayrandom;
        }
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість елементів масиву :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = ArrayRandom(n);
            ArrayWrite(array);
            ArrayEdit(array);
            ArrayWrite(array);
            Console.ReadKey();
        }
    }
}
