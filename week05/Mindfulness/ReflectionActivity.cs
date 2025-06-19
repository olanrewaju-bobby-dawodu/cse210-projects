using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this in mind in the future?"
    };

    public ReflectionActivity()
    {
        _activityName = "Reflection Activity";
        _description = "This activity helps you reflect on times when you showed strength and resilience.";
    }

    public override void PerformActivity()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {GetRandomItem(_prompts)} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder each of the following questions:");
        ShowSpinner(3);

        int elapsed = 0;
        Random rand = new Random();
        List<int> usedIndexes = new List<int>();

        while (elapsed < _duration)
        {
            int index = rand.Next(_questions.Length);
            Console.Write("> " + _questions[index]);
            PauseWithSpinner(5);
            elapsed += 5;
        }
    }
}
