using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Chatdesign
{
    class ChatMessage
    {
        public String body, sender, receiver, senderName;
        public String Date, Time;
        public String msgid;
        public Boolean isMine;// Did I send the message.

        public ChatMessage(String Sender, String Receiver, String messageString,
                    String ID, Boolean isMINE)
        {
            body = messageString;
            isMine = isMINE;
            sender = Sender;
            msgid = ID;
            receiver = Receiver;
            senderName = sender;
        }

        public void setMsgID()
        {

            msgid += "-" + String.Format("%02d", new Random().Next(100));
            ;
        }
    }
}