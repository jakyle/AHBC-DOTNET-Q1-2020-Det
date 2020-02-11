using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Messenger
    {
        public virtual void SendMessage(string message)
        {
            // do some shit.
        }
    }

    public class TextMessenger : Messenger
    {
        public override void SendMessage(string message)
        {
            // some logic to send a text
        }
    }

    public class EmailMessenger : Messenger
    {
        public override void SendMessage(string message)
        {
            // some logic to send emals
        }
    }
}
