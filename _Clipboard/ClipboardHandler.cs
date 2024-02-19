using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;

namespace ClipboardHistoryCLI._Clipboard
{
    internal class ClipboardHandler
    {
        private Dictionary<string, DataPackageView> _clipboardHistory = [];

        public ClipboardHandler()
        {
            Clipboard.ContentChanged += new EventHandler<object>(this.ClipboardChanged);
        }

        private void ClipboardChanged(object? sender, object e)
        {
            Console.WriteLine("TEST");
            Console.WriteLine($"{sender}, {e}");
            Console.WriteLine($"{sender.GetType()}, {e.GetType()}");
        }
    }
}
