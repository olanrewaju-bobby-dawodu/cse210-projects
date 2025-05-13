using System;

class Program
{
    static void Main(string[] args)
    {
        // For where the user specified the number, Part 1 and 2.
        // Console.Write("What's the magic number? ");
        
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        /// A do-while loop could also be used here.
        while (guess != magicNumber)
        {
            Console.Write("What's your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Correct!");
            }

        }
    }
}