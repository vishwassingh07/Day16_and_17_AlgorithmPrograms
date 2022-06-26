using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AnagramDetection
    {
        public void DetectingAnagrams()
        {
            Console.Write("Enter first word to check : ");
            string word1  = Console.ReadLine();
            Console.Write("Enter second word to check : ");
            string word2 = Console.ReadLine();

            char[] array1 = word1.ToLower().ToCharArray();
            char[] array2 = word2.ToLower().ToCharArray();

            
            Sorting(array1);
            Sorting(array2);

            string s1 = new string(array1);
            string s2 = new string(array2);

            if (s1.Equals(s2))
            {
                Console.WriteLine("Both the strings are anagrams of each other ");
            }
            else
            {
                Console.WriteLine("The given strings are not anagrams of each other");
            }
        }

        public void Sorting(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        char temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
