using System;
namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Algorithm Programs\n=================================");
            bool end = true;
            Console.WriteLine("1. Permutation of a word\n2. End of program");
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