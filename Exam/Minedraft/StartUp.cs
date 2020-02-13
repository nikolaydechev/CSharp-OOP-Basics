using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var manager = new DraftManager();
        bool terminated = false;

        while (!terminated)
        {
            var input = Console.ReadLine();
            var cmdArgs = input.Split(' ').ToList();
            var command = cmdArgs[0];
            cmdArgs.RemoveAt(0);
            try
            {
                manager.ExecuteCommand(cmdArgs, command);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            if (input == "Shutdown")
            {
                terminated = true;
            }
        }
    }
}
