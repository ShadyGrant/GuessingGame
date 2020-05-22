using System;
using System.Collections.Generic;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            int secretNumber = rand.Next(1, 101);;

            int guessesGiven = 0;

            //create a variable for the number of guess left
            int guessesLeft = 4;
            
            
            List<string> difLevel = new List<string>() { "Easy", "Medium", "Hard" };
           Console.WriteLine($"Select the Difficulty Level, {difLevel}");

            while (guessesGiven < 4)
            {
            

                Console.WriteLine($"Guess the secret number. Your Guess({guessesGiven + 1})");
                string userGuess = Console.ReadLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine("Yup! you guessed it");
                    break;
                }
                else
                {
                    Console.WriteLine($"Nope! that wasn't it!. You have ({guessesLeft - 1}) guesses left");
                }

                if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("your guess is too low");
                }
                else
                {
                    Console.WriteLine("your guess is too high");
                }

                guessesGiven++;
                guessesLeft--;

            }

        }
    }
}