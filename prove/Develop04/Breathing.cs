class BreathingActivity : Activity
{
    
    public BreathingActivity()
    {
    Console.WriteLine("Welcome to the Listing Activity");
    Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    Console.Write("How long, in seconds, would you like for your session?");


    }
    public void Run()
    {
        
    }
}
// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
// After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
// After each message, the program should pause for several seconds and show a countdown.
// It should continue until it has reached the number of seconds the user specified for the duration.
// The activity should conclude with the standard finishing message for all activities.