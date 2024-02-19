using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardHistoryCLI.CLI
{
    public class CommandParser
    {
        private string[] _args;

        public CommandParser(string[] args)
        {
            _args = args;
        }

        public string[] ListComponents()
        {
            string[] list_to_return = [];
            foreach (string arg in _args)
            {
                list_to_return.Append(arg);
                Console.WriteLine(arg);
            }
            return list_to_return;
        }
    }
}
