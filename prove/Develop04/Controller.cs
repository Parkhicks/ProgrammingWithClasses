public class Controller
    {
        public void ShowControls()
        {
            while (true)
            {
                Console.WriteLine("Please pick and your mindfullness excercise: ");
                Console.WriteLine("1. Breathing 1 \n2. Reflective 1\n3. Listing\n4. Exit");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    Breathing breathing = new Breathing();
                    breathing.StartActivity();
                }
                else if (input == "2")
                {
                    Reflection reflection = new Reflection();
                    reflection.StartActivity();
                }
                else if (input == "3")
                {
                    Listing listing = new Listing();
                    listing.StartActivity();
                }
                else if (input == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please try again.");
                }
            }
        }
    }