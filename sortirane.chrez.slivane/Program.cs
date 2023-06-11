using Microsoft.VisualBasic;
using System.Security.Cryptography;

namespace sortirane.chrez.slivane
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int[] array = { 7, 2, 1, 6, 8, 5, 3, 4 };

                Console.WriteLine("Unsorted array:");
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }

                Mergesort(array);

                Console.WriteLine("\nSorted array:");
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }

                Console.ReadLine();
            
        }
    }
}