using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lecture37
{
    class MessageViewModel
    {
        
        public MessageCommand cmd { get; set; }

        public MessageViewModel()
        {
            cmd = new MessageCommand(this);
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

    }
}