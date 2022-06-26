using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class StringPermutation
    {
        HashSet<string> set = new HashSet<string>();
        public void PermutationOfString()
        {
            Console.Write("Enter a string to check :  ");
            string word = Console.ReadLine();

            string result = "";
            permute(word, result);

            Console.Write("\nPermutations of string {0} are: \n", word);
            foreach (var s in set)
            {
                Console.WriteLine(s);
            }
        }

        void permute(string word, string result)
        {
            if (word.Length == 0)
            {
                set.Add(result);
                return;
            }
            for (int i = 0; i < word.Length; i++)
            {
                char character = word[i];
                String left_substring = word.Substring(0, i);
                String right_substring = word.Substring(i + 1);
                String rest = left_substring + right_substring;
                permute(rest, result + character);
            }
        }
    }
}
