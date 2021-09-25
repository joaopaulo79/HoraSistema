using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime agora = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\nAgora é exatamente {agora.DayOfWeek}, {agora}...\n");
            Console.ResetColor();
        }
    }
}
