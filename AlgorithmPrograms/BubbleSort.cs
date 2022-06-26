using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public static void BubbleSorting(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
        }
        public static void DisplayArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}
