using System;
using Clumsy.Interfaces;

namespace Clumsy
{
    public class StandardConsole : IConsole
    {
        public StandardConsole()
        {
            BannerValues = new BannerValues();
        }

        public BannerValues BannerValues { get; private set; }

        public void DrawBanner()
        {
            Console.BufferHeight = Console.WindowHeight;
            int oldX = Console.CursorLeft;
            int oldY = Console.CursorTop;
            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, 0);
            WriteLine(" CLuMSY v{0} | {1} | Program '{2}' | {3} . {4} . {5} | {6} BPM ",
                BannerValues.VersionString, BannerValues.PlaybackStatus, BannerValues.ProgramName,
                1, 1, 1, BannerValues.Bpm);
            Console.SetCursorPosition(oldX, Math.Max(2, oldY));
            Console.ResetColor();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(object value)
        {
            Console.WriteLine(value);
        }

        public void WriteLine(string format, params object[] values)
        {
            Console.WriteLine(format, values);
        }
    }
}