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

                }
                else if (input == "2")
                {

                }
                else if (input == "3")
                {

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