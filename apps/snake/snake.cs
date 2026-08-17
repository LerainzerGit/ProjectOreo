using System;
using System.Threading;

class Snake
{
    static void Main()
    {
        Console.CursorVisible = false;
        int x = 10, y = 10;

        while (true)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("O");

            Thread.Sleep(100);

            x++;
            if (x > 40) x = 0;
        }
    }
}
