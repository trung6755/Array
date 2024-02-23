        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input array size: ");
            int size = int.Parse(Console.ReadLine());


            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Input element " + i + ":");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Input position: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Position X value: ");
            int value = int.Parse(Console.ReadLine());
            for (int i = size - 1; i > x; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[x] = value;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
