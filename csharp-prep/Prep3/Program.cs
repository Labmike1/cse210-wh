using System;

class Program
{
    static void Main(string[] args)
    {
        // generate a random number // 
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        
        // Console.Write("What is your grade percentage? ");
        // Console.WriteLine($"Your grade is: {number}");

        int guess =0;

         // We could also use a do-while loop here...
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}