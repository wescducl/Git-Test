using System;

namespace First_Project
{
    class Program
    {
        private static int GetGuess()
        {
            int guess = 0;
            try
            {
                Console.WriteLine("Please enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter a valid guess.");
                guess = GetGuess();
            }
            return guess;
        }
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(0, 100);
            Console.WriteLine("I am thinking of a number between 0 - 100");
            int numberOfTries = 0;
            while (GetGuess() != randomNumber)
            {
                int guess = GetGuess();
                numberOfTries++;
                if (guess == randomNumber)
                {
                    Console.WriteLine("Your guess was correct! It took you " ,numberOfTries, " times to guess the number");
                    break;
                }
                if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess was too high!!");
                }
                if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess was too low!!");
                }
            }
          
        }
    }
}
