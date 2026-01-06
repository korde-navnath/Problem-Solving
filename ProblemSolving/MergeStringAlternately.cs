using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class MergeStringAlternately
    {
       public static string MergeAlternetly(string word1, string word2)
        {
            StringBuilder result = new StringBuilder();
            int i = 0;

            while(i < word1.Length || i < word2.Length)
            {
                if(i < word1.Length)
                {
                    result.Append(word1[i]);
                }
                if(i < word2.Length)
                {
                    result.Append(word2[i]);
                }
                i++;
            }
         return result.ToString();
        }
        public static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqr";
            string mergeString = MergeAlternetly(word1, word2);
            Console.WriteLine(mergeString);
        }
    }
}
