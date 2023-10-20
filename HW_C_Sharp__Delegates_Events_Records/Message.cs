using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_Sharp__Delegates_Events_Records
{
    internal class Message
    {
        string _messgae;

        public Message(string message)
        {
            _messgae = message;
        }

        public override string ToString()
        {
            return _messgae;
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
