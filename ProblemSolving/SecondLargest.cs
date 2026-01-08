using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class SecondLargest
    {
        public static int FindSecondLargest(int[] arr, int n)
        {
            int largest = arr[0];
            int secondLargest = int.MinValue;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else
                {
                    if(arr[i] > secondLargest && arr[i] != largest)
                    {
                        secondLargest = arr[i];
                    }
                }
            }
            return secondLargest;
        }
        
            public static void Main(string[] args)
        {
            int[] arr = { 12, 35, 1, 10, 34, 1 };
            int n = arr.Length;
            int secondLargest = FindSecondLargest(arr, n);
            Console.WriteLine("The second largest element is: " + secondLargest);
        }
    }
}
