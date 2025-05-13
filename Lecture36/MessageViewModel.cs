using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lecture36
{
    class MessageViewModel
    {
        public string? MessageText { get; set; }
        public MessageCommand cmd { get; set; }

        public MessageViewModel()
        {
            cmd = new MessageCommand(this);
        }

        public void DisplayMessage()
        {
            MessageBox.Show(MessageText);
        }   

    }
}
