using System;

public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        CurrentCount++;
        if (CurrentCount == TargetCount)
        {
            return Points + BonusPoints;
        }
        return Points;
    }

    public override string GetStatus()
    {
        return "[ ] " + Name + $" Completed {CurrentCount}/{TargetCount} times";
    }
}
