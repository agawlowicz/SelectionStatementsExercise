using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number.");
            var userInput = int.Parse(Console.ReadLine());

            //how to get the program to take input for a second guess
            while (favNumber != userInput)
            {
                if (userInput < favNumber)
                {
                    Console.WriteLine("too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("too high");
                }
                else
                {
                    Console.WriteLine("Nevermind");
                }
                Console.WriteLine("try again");
                userInput = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("good job! You guessed it!");

            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine().ToLower();

            switch (subject)
            {
                case "history":
                    Console.WriteLine("History is fascinating. We must learn about history so we don't repeat it.");
                    break;
                case "math":
                    Console.WriteLine("Math is the foundation for understanding the world around us. Everything can be simplified into math.");
                    break;
                case "english":
                    Console.WriteLine("English is a complex language and very intricate.");
                    break;
                case "biology":
                    Console.WriteLine("Biology helps us understand the ways in which all life is connected.");
                    break;
                case "chemistry":
                    Console.WriteLine("Chemistry is a very challenging subject.");
                    break;
                default:
                    Console.WriteLine("Sorry, I don't know that subject.");
                    break;

            }
        }
    }
}
