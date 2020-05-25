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

    

            Console.WriteLine("Choose a difficulty level:");
            Console.WriteLine("1) Easy");
            Console.WriteLine("2) Medium");
            Console.WriteLine("3) Hard");
            Console.WriteLine("4) Cheater");
            Console.WriteLine("5) Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    while (guessesGiven < 8)
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

                    break;

                case "2":
                    while (guessesGiven < 6)
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

                    break;

                case "3":
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

                    break;

                case "4":
                    while (guessesGiven < int.MaxValue)
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
                            Console.WriteLine($"Nope! that wasn't it!. You have UNLIMITED guesses left");
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

                    break;

            }
        }
    }
}