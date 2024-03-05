using System;

namespace Setup
{
    class Entry
    {
        public static void Start()
        {
            Console.Title = "Console C#";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to C# Terminal");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Created By Izanamii");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}