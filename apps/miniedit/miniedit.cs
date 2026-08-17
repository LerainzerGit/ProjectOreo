using System;
using System.IO;

class MiniEdit
{
    static void Main(string[] args)
    {
        Console.WriteLine("MiniEdit v1.0");
        Console.Write("File name: ");
        string file = Console.ReadLine();

        Console.WriteLine("Enter text. Type ':wq' to save and exit.");

        string content = "";
        while (true)
        {
            string line = Console.ReadLine();
            if (line == ":wq") break;
            content += line + "\n";
        }

        File.WriteAllText(file, content);
        Console.WriteLine("Saved.");
    }
}
