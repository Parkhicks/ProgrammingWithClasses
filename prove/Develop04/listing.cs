public class Listing : Activity
{
    string[] Prompts = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
     public void StartActivity(){
        base.StartBace();
        int rando = new Random().Next(0, Prompts.Length);
        Console.WriteLine(Prompts[rando]);
        base.countDown();
            
        int counter = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_time);

        while (DateTime.Now < endTime){
            string entrie = Console.ReadLine();
            if (!string.IsNullOrEmpty(entrie)) // I don't know if this works.
            {
                counter++;
            }}
        Console.WriteLine($"You listed {counter} items.");
        base.EndActivity();
        base.countDown();
     }


   
}