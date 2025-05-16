using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lecture38
{
    class MessageViewModel
    {

        public MessageCommand cmd { get; set; }
        public ConsoleMessageCommand cmd2 { get; set; }

        public MessageViewModel()
        {
            cmd = new MessageCommand(this);
            cmd2 = new ConsoleMessageCommand(this);
        }

        public bool canExecute(string? m)
        {
            if (string.IsNullOrEmpty(m))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DisplayMessage(string MessageText)
        {
            MessageBox.Show(MessageText);
        }

        public void DisplayMessageOnConsole(string MessageText)
        {
            Console.WriteLine(MessageText); 
        }

    }
}
