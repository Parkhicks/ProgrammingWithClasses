public class Controller
{
    public void ShowControls()
    {
        while (true)
        {
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. View Goals 1 \n2. Create Goals 1\n3. Complete a goals\n4. Save Goals\n5. Load Goals\n6. Exit");
            string input = Console.ReadLine();
            List<Eternal> Eternal_list = new List<Eternal>();
            List<Simple> Simple_list = new List<Simple>();
            List<Checklist> Checklist_list = new List<Checklist>();

            if (input == "1")
            {
                Console.WriteLine("\nGOALS\n-------------------\n\n");
                int count = 1;
                Console.WriteLine("Simple Goals:");
                foreach(Simple item in Simple_list)
                {
                    Console.WriteLine($"Goal {count}: {item.g_name} {item.Get_Status()}");
                    count += 1;
                }
                Console.WriteLine("\n\nEternal Goals: ");
                count = 1;
                foreach(Eternal item in Eternal_list)
                {
                    Console.WriteLine($"Goal {count}: {item.g_name} {item.Get_Status()}");
                    count += 1;
                }
                Console.WriteLine("\n\nChecklist Goals: ");
                count = 1;
                foreach(Checklist item in Checklist_list)
                {
                    Console.WriteLine($"Goal {count}: {item.g_name} {item.GetChecklistTime} {item.Get_Status()}");
                    count += 1;
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("What type of goal do you want to create? \n1. Simple goal\n2. Eternal Goal\n3. Checklist Goal");
                string input2 = Console.ReadLine();
                if (input2 == "1")
                {
                    Console.WriteLine("What is your goal?\n");
                    string nameof = Console.ReadLine();
                    Console.WriteLine("How many points do you want to get from this goal?\n");
                    int points = int.Parse(Console.ReadLine());
                    Simple simple = new Simple("S",points,nameof);
                    Simple_list.Add(simple);
                }
                else if (input2 == "2")
                {
                    Console.WriteLine("What is your eternal goal?\n");
                    string nameof = Console.ReadLine();
                    Console.WriteLine("How many points do you want every time you do this?\n");
                    int points = int.Parse(Console.ReadLine());
                    Eternal eternal = new Eternal("E",points,nameof);
                    Eternal_list.Add(eternal);
                }
                else if (input2 == "3")
                {
                    Console.WriteLine("What is your checklist goal?\n");
                    string nameof = Console.ReadLine();
                    Console.WriteLine("How many times do you want to do this task?\n");
                    int requirement = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many points do you want every time you do this?\n");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine($"How many points do you want when you complete this goal {requirement} times?\n");
                    int reward = int.Parse(Console.ReadLine());
                    Checklist checklist = new Checklist("C",points,nameof,reward,requirement);
                    Checklist_list.Add(checklist);
                }
                else
                {Console.WriteLine("Invalid input! Please try again.");}
            }
            else if (input == "3")
            {
                Console.WriteLine("Would you like to complete:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("\n\nPlease enter the number of the goal you want to complete: ");
                    int count = 1;
                        foreach(Simple item in Simple_list)
                    {
                        Console.WriteLine($"Goal {count}: {item.g_name}");
                        count += 1;
                    }
                    choice = int.Parse(Console.ReadLine());
                    Simple_list[choice-1].Complete_goal(user);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\n\nPlease enter the number of the goal you want to complete: ");
                    int count = 1;
                        foreach(Eternal item in Eternal_list)
                    {
                        Console.WriteLine($"Goal {count}: {item.g_name}");
                        count += 1;
                    }
                    choice = int.Parse(Console.ReadLine());
                    Eternal_list[choice-1].Complete_goal(user);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("\n\nPlease enter the number of the goal you want to complete: ");
                    int count = 1;
                        foreach(Checklist item in Checklist_list)
                    {
                        Console.WriteLine($"Goal {count}: {item.g_name}");
                        count += 1;
                    }
                    choice = int.Parse(Console.ReadLine());
                    Checklist_list[choice-1].Complete_goal(user);
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }
            }
            else if (input == "4")
            {
                break;
            }
            else if (input == "5")
            {

            }
            else if (input == "6")
            {
                
            }
            else
            {
                Console.WriteLine("Invalid input! Please try again.");
            }
        }
    }
}