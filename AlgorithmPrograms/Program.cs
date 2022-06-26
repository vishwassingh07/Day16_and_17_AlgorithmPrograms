using System;
namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Algorithm Programs\n=================================");
            bool end = true;
            Console.WriteLine("1. Permutation of a word\n2. Binary Search\n3. Inssertion Sorting\n4. End of program");
            while (end)
            {
                Console.Write("Choose an option to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        StringPermutation permutation = new StringPermutation();
                        permutation.PermutationOfString();
                        break;
                    case 2:
                        const string FILE_PATH = @"D:\RFP BATCH 157\AlgorithmProgram\Day16_and_17_AlgorithmPrograms\BinarySearchList.txt";
                        BinarySearch search = new BinarySearch();
                        string input_String = File.ReadAllText(FILE_PATH);
                        string[] array = input_String.Split(',');
                        int length = array.Length;
                        Console.Write("Enter the word to Search : ");
                        string key = Console.ReadLine();
                        int result = search.BinarySearchElement(array, 0, length - 1, key);
                        if (result == -1)
                        {
                            Console.WriteLine(key + " word is present in the file");
                        }
                        else
                        {
                            Console.WriteLine(key + " Word is  not present ");
                        }
                        break;
                    case 3:
                        String[] array1 = { "Baghel", "Cat", "English", "Vishwas", "Name", "Apple" };
                        InsertionSort sorting = new InsertionSort();
                        sorting.Sorting(array1);
                        sorting.DisplayArray(array1);
                        break;
                    case 4:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("You choose an invalid option ");
                        break;
                }
            }
        }
    }
}