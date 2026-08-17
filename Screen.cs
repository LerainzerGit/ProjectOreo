using System;

public static class Screen
{
    public static void Clear()
    {
        Console.Clear();
    }

    public static void Write(string text)
    {
        Console.Write(text);
    }

    public static void WriteLine(string text)
    {
        Console.WriteLine(text);
    }

    public static void WriteCentered(string text)
    {
        int width = Console.WindowWidth;
        int left = Math.Max(0, (width - text.Length) / 2);
        Console.SetCursorPosition(left, Console.CursorTop);
        Console.WriteLine(text);
    }

    public static void DrawBootBanner()
    {
        Console.Clear();
        WriteLine("========================================");
        WriteLine("           PROJECT OREO BOOT            ");
        WriteLine("========================================");
        WriteLine("");
    }
}
