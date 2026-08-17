using System;

static class Sudo
{
    public static void Handle(string[] p, ref bool network)
    {
        if (p.Length < 2)
        {
            Console.WriteLine("sudo requires a subcommand.");
            return;
        }

        string sub = p[1].ToLower();

        if (sub == "install")
        {
            Install(p);
        }
        else if (sub == "connect")
        {
            Connect(p, ref network);
        }
        else
        {
            Console.WriteLine("Unknown sudo subcommand.");
        }
    }

    static void Install(string[] p)
    {
        if (p.Length < 3)
        {
            Console.WriteLine("Usage: sudo install <app>");
            return;
        }

        string app = p[2].ToLower();

        switch (app)
        {
            case "miniedit":
            case "snake":
            case "sysinfo":
                Console.WriteLine($"Installing {app}...");
                Console.WriteLine($"{app} installed.");
                break;

            default:
                Console.WriteLine("App not found.");
                break;
        }
    }

    static void Connect(string[] p, ref bool network)
    {
        if (p.Length < 4)
        {
            Console.WriteLine("Usage: sudo connect <ssid> <pass>");
            return;
        }

        network = true;
        Console.WriteLine("Connected to internet.");
    }
}
