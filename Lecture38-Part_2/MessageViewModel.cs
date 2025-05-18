using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lecture38_Part_2
{
    class MessageViewModel
    {

        public DelegateCommand cmd { get; set; }
        public DelegateCommand cmd2 { get; set; }

        public MessageViewModel()
        {
            cmd = new DelegateCommand(DisplayMessage, canExecute);
            cmd2 = new DelegateCommand(DisplayMessageOnConsole, canExecute);
        }

        public bool canExecute(object m)
        {
            if (string.IsNullOrEmpty(m as string))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DisplayMessage(object m)
        {
            MessageBox.Show(m as string);
        }

        public void DisplayMessageOnConsole(object MessageText)
        {
            Console.WriteLine(MessageText);
        }

    }
}
