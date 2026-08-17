using System;

class Program
{
    static void Main(string[] args)
    {
        Screen.DrawBootBanner();
        Screen.WriteLine("Loading terminal...");
        Screen.WriteLine("");

        Screen.WriteLine("Welcome to Project Oreo.");
        Screen.WriteLine("Type 'help' for commands.");

        while (true)
        {
            Screen.Write("> ");
            string input = Console.ReadLine();

            if (input == null)
                continue;

            input = input.Trim().ToLowerInvariant();

            if (input == "exit")
                break;
            else if (input == "help")
            {
                Screen.WriteLine("Available commands:");
                Screen.WriteLine("  help  - show this help");
                Screen.WriteLine("  exit  - quit");
                Screen.WriteLine("  miniedit - launch MiniEdit");
                Screen.WriteLine("  snake - launch Snake");
                Screen.WriteLine("  sysinfo - show system info");
            }
            else if (input == "miniedit")
            {
                Screen.WriteLine("Launching MiniEdit...");
                // hook into miniedit.exe later
            }
            else if (input == "snake")
            {
                Screen.WriteLine("Launching Snake...");
                // hook into snake.exe later
            }
            else if (input == "sysinfo")
            {
                Screen.WriteLine("Project Oreo system info:");
                Screen.WriteLine("  Memory: 64 MB (emulated)");
                Screen.WriteLine("  Display: v86 text console");
            }
            else
            {
                Screen.WriteLine("Unknown command: " + input);
            }

            Screen.WriteLine("");
        }

        Screen.WriteLine("Shutting down Project Oreo...");
    }
}
