using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class LargestElementInArray
    {
        public static int FindLargestInArray(int[] arr, int n)
        {
            int largest = arr[0];

            for(int i = 1; i < n; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            return largest;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 3, 5, 7, 2, 8, -1, 4 };
            int n = arr.Length;
            int temp
                = FindLargestInArray(arr, n);
            Console.WriteLine(temp);
        }
    }
}
