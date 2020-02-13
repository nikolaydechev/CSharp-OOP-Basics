using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var nationBuilder = new NationsBuilder();

        while (true)
        {
            var input = Console.ReadLine();
            var data = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            nationBuilder.ExecuteCommand(data);
            if (input == "Quit")
            {
                break;
            }
        }
    }
}
