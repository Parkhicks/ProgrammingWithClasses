// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Player Ronalado = new Player("Christiano Ronaldo",7);
Ronalado.Display();

Player Messi = new Player("Lionel Messi", 10);
Messi.Display();

Team cardinals = new Team("Cardinals");
cardinals.AddPlayer(Messi);
cardinals.AddPlayer(Ronalado);
cardinals.DisplayRoster();