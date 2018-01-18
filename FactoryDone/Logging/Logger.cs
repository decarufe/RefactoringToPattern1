using System;

namespace FactoryDone.Logging
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ForegroundColor = currentColor;
        }
    }
}