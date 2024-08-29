using System;

class NumberGuessingGame
{
    static void Main()
    {
        Random random = new Random();
        int winningNumber = random.Next(1, 101);
        bool hasGuessedCorrectly = false;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I've selected a number between 1 and 100.");
        Console.WriteLine($"You have {chances} chances to guess the number.");

        for (int i = 0; i < chances; i++)
        {
            Console.Write("Please enter your guess: ");
            int userGuess;

            while (!int.TryParse(Console.ReadLine(), out userGuess) || userGuess < 1 || userGuess > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
            }

            if (userGuess == winningNumber)
            {
                hasGuessedCorrectly = true;
                break;
            }
            else if (userGuess < winningNumber)
            {
                Console.WriteLine("Your guess is smaller than the winning number.");
            }
            else
            {
                Console.WriteLine("Your guess is bigger than the winning number.");
            }
        }

        if (hasGuessedCorrectly)
        {
            Console.WriteLine($"Congratulations! You've guessed the winning number: {winningNumber}");
        }
        else
        {
            Console.WriteLine($"Sorry! You've used all your chances. The winning number was: {winningNumber}");
        }
    }
}