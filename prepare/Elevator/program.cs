// See https://aka.ms/new-console-template for more information


Elevator elevator_1 = new Elevator();
VIP vip_ele = new VIP();


elevator_1.open_door();
elevator_1.close_door();
elevator_1.move_floor(1234);



Console.WriteLine("\n\nVIP ELEVATOR\n\n");

vip_ele.open_door();
vip_ele.close_door();
vip_ele.move_floor(1234);