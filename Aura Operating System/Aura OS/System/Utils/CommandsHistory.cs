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
            Cosmos.System.Console.commandindex++;
        }

        public static int GetListIndex()
        {
            int i = Cosmos.System.Console.commandindex;
            i -= 1;
            return i;
        }

        public static void GetUpCommand()
        {
            ClearCurrentConsoleLine();
            Cosmos.System.Console.cmd = "ls";
            Cosmos.System.Console.writecommand = true;

            Kernel.BeforeCommand();
            //string text = Console.ReadLine();

            Shell.cmdIntr.CommandManager._CommandManger("ls");

            Cosmos.System.Console.writecommand = false;
        }

        public static void GetDownCommand()
        {
            ClearCurrentConsoleLine();
            Cosmos.System.Console.cmd = "echo pizza";
            Cosmos.System.Console.writecommand = true;

            Kernel.BeforeCommand();
            string text = Console.ReadLine();

            Shell.cmdIntr.CommandManager._CommandManger(text);

            Cosmos.System.Console.writecommand = false;
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
