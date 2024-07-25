using System;

public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public string Address { get; set; }

    public Event(string title, string description, DateTime date, string time, string address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string StandardDetails()
    {
        return $"Event Title: {Title}\nDescription: {Description}\nDate: {Date:yyyy-MM-dd}\nTime: {Time}\nAddress: {Address}";
    }

    public virtual string FullDetails()
    {
        return StandardDetails() + $"\nEvent Type: {GetType().Name}";
    }

    public virtual string ShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {Title}\nDate: {Date:yyyy-MM-dd}";
    }
}

public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, string time, string address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}

public class Reception : Event
{
    public string RSVPEmail { get; set; }

    public Reception(string title, string description, DateTime date, string time, string address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RSVPEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nRSVP Email: {RSVPEmail}";
    }
}

public class OutdoorGathering : Event
{
    public string Weather { get; set; }

    public OutdoorGathering(string title, string description, DateTime date, string time, string address, string weather)
        : base(title, description, date, time, address)
    {
        Weather = weather;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nWeather: {Weather}";
    }
}

class Program
{
    static void Main()
    {
        Event lecture = new Lecture("Science Talk", "A lecture on the latest in science.", new DateTime(2024, 8, 1), "10:00 AM", "123 Science St", "Dr. John Doe", 100);
        Event reception = new Reception("Networking Event", "Meet and network with professionals.", new DateTime(2024, 8, 5), "6:00 PM", "456 Business Rd", "rsvp@networking.com");
        Event outdoorGathering = new OutdoorGathering("Community Picnic", "An outdoor gathering for the community.", new DateTime(2024, 8, 10), "12:00 PM", "789 Park Ave", "Sunny");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.ShortDescription());
    }
}
