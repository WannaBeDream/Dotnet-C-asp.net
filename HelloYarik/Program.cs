using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.Title = "Бля взломали демоны";
            string hello = "Привет Ярик,да я тебя взломал";
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine(hello);
                key = Console.ReadKey(true);

                if ((key.Modifiers & ConsoleModifiers.Control) != 0)
                    Console.WriteLine("Добро пожаловать в жестокий мир С# клавиша ctrl удалена");
                if ((key.Modifiers & ConsoleModifiers.Alt) != 0)
                    Console.WriteLine("Добро пожаловать в жестокий мир С# клавиша ALT удалена");
                Console.WriteLine(key.Key.ToString() + " НЕ ПОМОЖЕТ ");
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}