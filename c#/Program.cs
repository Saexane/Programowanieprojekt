using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;
        String response;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            response = "";
            number = random.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);

                if (guess > number)
                {
                    Console.WriteLine(guess + " is too high!");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " is too low!");
                }
                guesses++;
            }
            Console.WriteLine("Number: " + number);
            Console.WriteLine("You won!");
            Console.WriteLine("Guesses: " + guesses);

            Console.WriteLine("Would You like to play again (Y/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thank You for playing!");
        Console.ReadKey();
    }
}
