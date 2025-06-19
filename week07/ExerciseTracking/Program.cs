using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 3.0)); //distance in miles
        activities.Add(new Cycling("03 Nov 2022", 45, 15.0)); //speed in mph
        activities.Add(new Swimming("03 Nov 2022", 40, 20));  // laps

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

// --------- BASE CLASS--------------------------

public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public string GetDate() => _date;
    public int GetLengthMinutes() => _lengthMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lengthMinutes} min) - " +
               $"Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}

// --------RUNNING CLASS ---------------

public class Running : Activity
{
    private double _distanceMiles;

    public Running(string date, int lengthMinutes, double distanceMiles)
        : base(date, lengthMinutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance() => _distanceMiles;

    public override double GetSpeed()
    {
        return (_distanceMiles / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / _distanceMiles;
    }
}

//---------- CYCLING CLASS-------------------

public class Cycling : Activity
{
    private double _speedMph;

    public Cycling(string date, int lengthMinutes, double speedMph)
        : base(date, lengthMinutes)
    {
        _speedMph = speedMph;
    }

    public override double GetSpeed() => _speedMph;

    public override double GetDistance()
    {
        return (_speedMph * GetLengthMinutes()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speedMph;
    }
}

// -------------------- SWIMMING CLASS ------------

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        //Each lap = 50 meters. Converted to km, then to miles...
        return (_laps * 50.0 / 1000.0) * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / GetDistance();
    }
}