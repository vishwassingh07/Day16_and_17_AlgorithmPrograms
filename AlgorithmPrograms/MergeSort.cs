using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class MergeSort
    {

        public void MergeSorting()
        {
            string[] stringArray = {"motorola", "bubble", "samsung", "razorphone","apple", "nokia", "oppo", "vivo" };

            sortingArray(stringArray, 0, stringArray.Length - 1);

            Console.WriteLine("Array after sorting : ");
            printArray(stringArray);
        }

        public void MergeArray(string[] array, int left, int mid, int right)
        {
            int L = mid - left + 1;     // Size of left subarray
            int R = right - mid;        // Size of right subarray

            string[] leftArray = new string[L];
            string[] rightArray = new string[R];

            int i, j;
            for (i = 0; i < L; ++i)
            {
                leftArray[i] = array[left + i];
            }

            for (j = 0; j < R; ++j)
            {
                rightArray[j] = array[mid + 1 + j];
            }

            i = 0;
            j = 0;

            int k = left;
            while (i < L && j < R)
            {
                if (leftArray[i].CompareTo(rightArray[j]) <= 0)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < L)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < R)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }

        void sortingArray(string[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                sortingArray(array, left, mid);

                sortingArray(array, mid + 1, right);

                MergeArray(array, left, mid, right);
            }

        }
        void printArray(string[] array)
        {
            foreach (var str in array)
            {
                Console.Write(str + "  ");
            }
        }
    }
}
