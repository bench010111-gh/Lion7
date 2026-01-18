using System;

namespace FishTyper
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var game = new Game();
            game.Run();
        }
    }
}
