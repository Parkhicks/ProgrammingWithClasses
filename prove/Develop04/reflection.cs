public class Reflection : Activity
{
    string[] Prompts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
    string [] Questions = {"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
    public Reflection() : base("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }
        public void StartActivity()
    {
        base.StartBace();
        Console.Clear();
        int rando = new Random().Next(0, Prompts.Length);
        Console.WriteLine("Reflect on these nuts");
        base.countDown();
        Console.WriteLine(Prompts[rando]);
        Thread.Sleep(_mathTime/3);
        Console.WriteLine(Questions[1]);
        Thread.Sleep(_mathTime/3);
        Console.WriteLine(Questions[0]);
        Thread.Sleep(_mathTime/3);
        base.EndActivity();
        base.countDown();


    }
   
}