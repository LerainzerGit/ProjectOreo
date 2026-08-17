using System;

class Program
{
    static bool network = false;

    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Project Oreo v1.0");
        Console.WriteLine("Type 'help' to begin.\n");

        while (true)
        {
            Console.Write("oreo> ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) continue;

            string[] p = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string cmd = p[0].ToLower();

            switch (cmd)
            {
                case "help":
                    Console.WriteLine("help - Show commands");
                    Console.WriteLine("ping <site> - Ping website");
                    Console.WriteLine("pong - Play pong");
                    Console.WriteLine("sudo install <app>");
                    Console.WriteLine("sudo connect <ssid> <pass>");
                    Console.WriteLine("run <app> - Run installed app");
                    break;

                case "ping":
                    if (!network)
                    {
                        Console.WriteLine("Not connected. Use 'sudo connect'.");
                        break;
                    }
                    if (p.Length < 2)
                    {
                        Console.WriteLine("Usage: ping <site>");
                        break;
                    }
                    Console.WriteLine($"Pinging {p[1]}...");
                    Console.WriteLine("Reply: time=42ms");
                    Console.WriteLine("Reply: time=41ms");
                    Console.WriteLine("Reply: time=40ms");
                    break;

                case "pong":
                    PlayPong();
                    break;

                case "sudo":
                    Sudo.Handle(p, ref network);
                    break;

                case "run":
                    if (p.Length < 2)
                    {
                        Console.WriteLine("Usage: run <app>");
                        break;
                    }
                    string app = p[1].ToLower();
                    try
                    {
                        System.Diagnostics.Process.Start("mono", $"/bin/{app}.exe");
                    }
                    catch
                    {
                        Console.WriteLine("App not found or failed to run.");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
    }

    static void PlayPong()
    {
        Random r = new Random();
        int score = 0;

        Console.WriteLine("PONG — press ENTER to hit!");

        while (true)
        {
            Console.ReadLine();
            if (r.Next(0, 10) > 2)
            {
                score++;
                Console.WriteLine($"Hit! Score: {score}");
            }
            else
            {
                Console.WriteLine("Miss! Game over.");
                break;
            }
        }
    }
}
