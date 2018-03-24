using System;
using System.Collections.Generic;
using System.Text;

namespace Aura_OS.System.Utils
{
    class CommandsHistory
    {

        private static List<string> CommandsList = new List<string>();
        private static int index = 0;
        
        public static void Add(string cmd)
        {
            CommandsList.Add(cmd);
            index++;
        }

        public static int GetIndex()
        {
            return index;
        }

        public static string GetUpCommand(int index)
        {
            Kernel.cmd = CommandsList[index - 1];
            return CommandsList[index - 1];
        }

        public static string GetDownCommand(int index)
        {
            index--;
            Kernel.cmd = CommandsList[index - 1];
            return CommandsList[index - 1];
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

    }
}
