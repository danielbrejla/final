using Rock_Paper_Scissors;

Hra game = new Hra();
string[] mindgame = { "KÁMEN ", "PAPÍR", "NŮŽKY" };

while (true)
{
game:
    int random = game.generator.Next(0, 3);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"TVOJE SKORE: {game.Player}");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"SKORE NEPŘÍTELE: {game.Enemy}");
    Console.ResetColor();
    Console.WriteLine($"------------------------------\n1 - KÁMEN\n2 - PAPÍR\n3 - NŮŽKY\n------------------------------");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input > 3)
    {
        Console.WriteLine("ŠPATNÁ HODNOTA");
        Thread.Sleep(2000);
        Console.Clear();
        goto game;
    }
    Console.Clear();

    if (mindgame[random] == "PAPÍR" && mindgame[input - 1] == "KÁMEN" || mindgame[random] == "NŮŽKY" && mindgame[input - 1] == "PAPÍR" || mindgame[random] == "KÁMEN" && mindgame[input - 1] == "NŮŽKY")
    {
        game.Enemy++;
        Console.WriteLine($"VYBRAL JSI {mindgame[input - 1]}\nNEPRITEL VYBRAL {mindgame[random]}\nPROHRAL JSI");
        Thread.Sleep(2500);
        Console.Clear();
    }
    else if (mindgame[random] == "NŮŽKY" && mindgame[input - 1] == "KÁMEN" || mindgame[random] == "KÁMEN" && mindgame[input - 1] == "PAPÍR" || mindgame[random] == "PAPÍR" && mindgame[input - 1] == "NŮŽKY")
    {
        game.Player++;
        Console.WriteLine($"vybral jsi {mindgame[input - 1]}\nnepritel vybral {mindgame[random]}\nvyhral jsi");
        Thread.Sleep(2500);
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"oba dva jste vybrali {mindgame[input - 1]}");
        Thread.Sleep(2000);
        Console.Clear();
    }
    if (game.Player >= 5 || game.Enemy >= 5)
    {
        break;
    }
}
if (game.Player > game.Enemy)
{
    Console.WriteLine("vyhral jsi a prestan cheatovat");
}
else
{
    Console.WriteLine("prohral si troubo");
}
