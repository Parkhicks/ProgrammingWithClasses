// See https://aka.ms/new-console-template for more information


Elevator elevator_1 = new Elevator();
VIP vip_ele = new VIP();
Elevator elevator_2 = new Elevator();

Console.WriteLine("Which elevator do you want? Elevator 1(1). Elevator 2(2) or VIP Elevator(3). ");
int choice = int.Parse(Console.ReadLine());
if (choice == 1)
{
    elevator_1.open_door();
    elevator_1.close_door();
    elevator_1.move_floor(1234);
}
else if (choice == 2)
{
    elevator_2.open_door();
    elevator_2.close_door();
    elevator_2.move_floor(1234);
}
else if (choice == 3)
{
    vip_ele.open_door();
    vip_ele.close_door();
    vip_ele.move_floor(1234);
}
