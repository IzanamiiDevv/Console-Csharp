using System;
using CMD;
using Setup;

class Program
{
    public static void Main(string[] args)
    {
        Entry.Start();
        Console.WriteLine("Write a Terminal Command!");
        string command = Console.ReadLine() ?? "";
        CMD.CMD.RunTerminalCommand(command);
        Console.ReadKey();
    }
}