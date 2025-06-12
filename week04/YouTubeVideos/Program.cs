class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //Video 1
        Video v1 = new Video("C# Tutorial", "BYU-Academy", 600);
        v1.AddComment(new Comment("Alice", "This was super helpful!"));
        v1.AddComment(new Comment("Bob", "Great explanation."));
        v1.AddComment(new Comment("Charlie", "Could you do a follow-up?"));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Understanding Abstraction", "DevInsights", 450);
        v2.AddComment(new Comment("Diana", "Awesome content!"));
        v2.AddComment(new Comment("Eli", "Abstraction finally makes sense."));
        v2.AddComment(new Comment("Frank", "I love this channel."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Learn C# in 10 Minutes", "QuickLearner", 700);
        v3.AddComment(new Comment("Grace", "Best quick tutorial."));
        v3.AddComment(new Comment("Hank", "Very efficient, thanks!"));
        v3.AddComment(new Comment("Ivan", "Perfect intro."));
        videos.Add(v3);

        //Displaying all videos and their comments...
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}
