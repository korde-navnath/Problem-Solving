using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class GretestCommonDivisor
    {
        public static void Main(string[] args)
        {
            string str1 = "ABCABC";
            string  str2 = "ABC";
            string gcd = FindGCD(str1, str2);
            Console.WriteLine($"The GCD of {str1} and {str2} is: {gcd}");
        }
        public static string FindGCD(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
            {
                return "";
            }
            int gcdLength = GCD(str1.Length, str2.Length);
            return str1.Substring(0, gcdLength);
        }
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

    }
}
