using System;

public class SimpleGoal : Goal
{
    public bool IsCompleted { get; private set; }

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        IsCompleted = false;
    }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return IsCompleted ? "[X] " + Name : "[ ] " + Name;
    }

    public void SetIsCompleted(bool isCompleted)
    {
        IsCompleted = isCompleted;
    }
}
