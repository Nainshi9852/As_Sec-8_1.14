using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadKey();
        }
        // Linear search function
        static int LinearSearch(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i; // Found, return the index
                }
            }
            return -1; // Not found
        }
        // Method to run the Linear Search
        static void runApp()
        {
            int[] arr = { 10, 5, 3, 8, 1,90,78,67};
            int searchValue;

            Console.Write("Enter a value to search for: ");
            if (int.TryParse(Console.ReadLine(), out searchValue))
            {
                try
                {
                    int result = LinearSearch(arr, searchValue);
                    if (result != -1)
                    {
                        Console.WriteLine($"Value found at index: {result}");
                    }
                    else
                    {
                        throw new Exception("Value not found in the array.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
            }
        }


    }
}
