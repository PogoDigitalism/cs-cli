using System;
using System.Runtime.CompilerServices;
using ClipboardHistoryCLI._Clipboard;
using ClipboardHistoryCLI.CLI;
using Windows.ApplicationModel.DataTransfer;

namespace ClipboardHistoryCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClipboardHandler handler = new ClipboardHandler();

            CommandParser parser = new CommandParser(args);
            string[] list;

            list = parser.ListComponents();
            Console.WriteLine($"{list} TEST");

/*            do
            {
                Console.WriteLine("HI");
                Thread.Sleep(1000);
            }
            while (true);*/
        }
    }
}