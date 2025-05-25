// Creativity added... randomly picking scripttures for memorization' from the short created library...

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>()
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son"),
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding"),
            new Scripture(new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want")
        };

        Random random = new Random();

        bool quit = false;

        while (!quit)
        {
            // Creativity', Selecting random scripture...
            Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            // Reseting scripture words to visible (new Scripture instance each loop helps with this)
            Console.Clear();
            Console.WriteLine("Memorize the scripture:");
            Console.WriteLine(currentScripture.GetDisplayText());

            while (true)
            {
                Console.WriteLine("\nTap Enter to hide words or type 'quit' to exit:");
                string input = Console.ReadLine();

                if (input.Trim().ToLower() == "quit")
                {
                    quit = true;
                    break;
                }

                currentScripture.HideRandomWords(3); // 3 words hidden per round...
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());

                if (currentScripture.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words hidden. Nicely done!");
                    break;
                }
            }
        }
    }
}