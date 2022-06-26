using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class InsertionSort
    {
        public void Sorting(string[] stringArray)
        {
            for (int i = 1; i < stringArray.Length; ++i)
            {
                string key = stringArray[i];
                int j = i - 1;
                while (j >= 0 && stringArray[j].CompareTo(key) > 0)
                {
                    stringArray[j + 1] = stringArray[j];
                    j = j - 1;
                }
                stringArray[j + 1] = key;
            }
        }

        public void DisplayArray(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; ++i)
            {
                Console.Write(stringArray[i] + "\n");
            }
        }
    }
}
