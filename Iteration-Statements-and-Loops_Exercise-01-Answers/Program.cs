using System;
using System.Collections.Generic;

namespace Iteration_Statements_and_Loops_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 7, 9, 4, 2, 3, 8, 10 };

            // TODO: Create a foreach loop to iterate through arr1 and print it's elements to the console
            foreach (var element in arr1)
            {
                Console.WriteLine(element);
            }

            AddSpaces();


            // TODO: Create a for loop to iterate through arr1 IN REVERSE ORDER and print it's elements to the console
            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr1[i]);
            }

            AddSpaces();

            // TODO: Create a do-while loop that asks the user for a number and then adds it to a list called numbers
            // TODO: Make the do-while loop terminate when the user types 'exit' 
            var userInput = "";
            var numbers = new List<int>();

            do
            {
                Console.WriteLine("Type 'quit' to exit the loop.");
                Console.Write("Give me a number and I will add it to the list: ");
                userInput = Console.ReadLine().ToLower();
                AddSpaces();
                var canParse = int.TryParse(userInput, out int num);
                numbers.Add(num);
            } while (userInput != "quit");

            AddSpaces();

            // TODO: Create a while loop that prints out all the nums inside numbers
            var index = 0;
            while (numbers[index] != numbers[numbers.Count - 1])
            {
                Console.WriteLine(numbers[index]);
                index++;
            }


        }

        public static void AddSpaces()
        {
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
