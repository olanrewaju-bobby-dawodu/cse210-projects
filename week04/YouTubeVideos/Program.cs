using System;
using System.Collections.Generic;

// Represents a single YouTube Video
public class YouTubeVideo
{
    // Attributes
    private string title;
    private string uploader;
    private int durationInSeconds; // Duration of video

    // Constructor
    public YouTubeVideo(string title, string uploader, int durationInSeconds)
    {
        this.title = title;
        this.uploader = uploader;
        this.durationInSeconds = durationInSeconds;
    }

    // Behaviors (methods)
    public void Play()
    {
        Console.WriteLine($"Playing '{title}' by {uploader}...");
    }

    public void Pause()
    {
        Console.WriteLine($"Paused '{title}'.");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Uploader: {uploader}");
        Console.WriteLine($"Duration: {durationInSeconds / 60}m {durationInSeconds % 60}s");
    }
}

// Program to demonstrate usage
public class Program1
{
    public static void Main()
    {
        YouTubeVideo video1 = new YouTubeVideo("Learning C# Basics", "CodeAcademy", 540);
        YouTubeVideo video2 = new YouTubeVideo("Object-Oriented Programming", "TechWorld", 720);

        video1.ShowInfo();
        video1.Play();
        video1.Pause();

        Console.WriteLine();

        video2.ShowInfo();
        video2.Play();
    }
}
