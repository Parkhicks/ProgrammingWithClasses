public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    public void StartActivity()
    {
        base.StartBace();
        Console.WriteLine("Take a deep breath");
        Console.WriteLine("Breath in...");
        base.countDown();
        Console.WriteLine("Breath out...");
        base.countDown();
        // Thread.Sleep(_mathTime/2);
        base.EndActivity();
        base.countDown();
        }
}