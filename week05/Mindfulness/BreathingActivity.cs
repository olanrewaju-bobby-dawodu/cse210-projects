using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _description = "This activity helps you relax by guiding you through slow breathing.";
    }

    public override void PerformActivity()
    {
        int cycleDuration = 8;
        int elapsed = 0;

        while (elapsed + cycleDuration <= _duration)
        {
            Console.Write("\nBreathe in... ");
            Countdown(4);
            Console.Write("Breathe out... ");
            Countdown(4);
            elapsed += cycleDuration;
        }
    }
}
