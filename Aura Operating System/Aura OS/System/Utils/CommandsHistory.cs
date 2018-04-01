using System;
using System.Collections.Generic;
using System.Text;

namespace Aura_OS.System.Utils
{
    class CommandsHistory
    {        
        public static void Add(string cmd)
        {
            Cosmos.System.Console.commands.Add(cmd);
        }

        public static int GetListIndex()
        {
            int i = Cosmos.System.Console.commandindex;
            i -= 1;
            return i;
        }

        public static string GetUpCommand()
        {
            ClearCurrentConsoleLine();            
            
            Cosmos.System.Console.writecommand = true;

            string text = Console.ReadLine();

            Cosmos.System.Console.writecommand = false;

            return text;
        }

        public static string GetDownCommand()
        {
            ClearCurrentConsoleLine();

            Cosmos.System.Console.commands.Add("echo pizza");
            Cosmos.System.Console.writecommand = true;
            Cosmos.System.Console.commandindex = 0;

            string text = Console.ReadLine();

            Cosmos.System.Console.writecommand = false;

            return text;
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
