using System;
using System.Collections.Generic;

public abstract class Activity
{
    public DateTime Date { get; private set; }
    public int DurationMinutes { get; private set; }

    public Activity(DateTime date, int durationMinutes)
    {
        Date = date;
        DurationMinutes = durationMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace(); 

    public string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({DurationMinutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}

public class Running : Activity
{
    public double DistanceMiles { get; private set; }

    public Running(DateTime date, int durationMinutes, double distanceMiles)
        : base(date, durationMinutes)
    {
        DistanceMiles = distanceMiles;
    }

    public override double GetDistance() => DistanceMiles;

    public override double GetSpeed() => (DistanceMiles / DurationMinutes) * 60;

    public override double GetPace() => DurationMinutes / DistanceMiles;
}

public class Cycling : Activity
{
    public double SpeedMph { get; private set; }

    public Cycling(DateTime date, int durationMinutes, double speedMph)
        : base(date, durationMinutes)
    {
        SpeedMph = speedMph;
    }

    public override double GetDistance() => (SpeedMph * DurationMinutes) / 60;

    public override double GetSpeed() => SpeedMph;

    public override double GetPace() => 60 / SpeedMph;
}

public class Swimming : Activity
{
    public int Laps { get; private set; }

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance() => Laps * 50 / 1000.0 * 0.62;

    public override double GetSpeed() => (GetDistance() / DurationMinutes) * 60;

    public override double GetPace() => DurationMinutes / GetDistance();
}

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 3), 30, 9.7),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
