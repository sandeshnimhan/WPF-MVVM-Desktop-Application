using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    class TextDisplay
    {
        private readonly Func<string, string> _display;

        public TextDisplay(Func<string, string> display)
        {
            _display = display;
        }

        public string DisplayText(string inputText)
        {
            return _display(inputText);
        }
    }
}
