using System;

public class StartUp
{
    public static void Main()
    {
        var carManager = new CarManager();

        string input;
        while ((input = Console.ReadLine()) != "Cops Are Here")
        {
            carManager.InterpretCommand(input);

        }
    }
}
