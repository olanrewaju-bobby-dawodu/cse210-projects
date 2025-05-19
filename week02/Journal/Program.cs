// Exceeding Requirement added:
// -- User can now inputs a Mood Rating (1–10) for each entry
// -- Rating is now stored, displayed, and saved/loaded with entries...

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Welcome to your Journal!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                Console.Write("Your entry: ");
                string entryText = Console.ReadLine();

                Console.Write("On a scale of 1–10, how was your mood today? ");
                int moodRating = int.Parse(Console.ReadLine()); //  Mood rating input...

                string date = DateTime.Now.ToShortDateString();
                Entry entry = new Entry(date, prompt, entryText, moodRating); // Passing mood rating to entry...
                journal.AddEntry(entry);
                Console.WriteLine("Entry saved!");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter a filename to save the journal: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename); // Save with mood rating...
                Console.WriteLine("Journal saved!");
            }
            else if (choice == "4")
            {
                Console.Write("Enter a filename to load the journal: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename); //  Loading with mood rating...
                Console.WriteLine("Journal loaded!");
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}
