using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using static Android.Views.View;

namespace Chatdesign
{
    [Activity(Label = "Chatdesign", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, IOnClickListener
    {
        private EditText msg_edittext;
        private String user1 = "khushi", user2 = "khushi1";
        private Random random;
        private List<ChatMessage> chatlist;
        private static ChatAdapter chatAdapter;
        ListView msgListView;

        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            random = new Random();
            msg_edittext = (EditText)FindViewById(Resource.Id.messageEditText);
            msgListView = (ListView)FindViewById(Resource.Id.msgListView);
            ImageButton sendButton = (ImageButton)FindViewById(Resource.Id.sendMessageButton);
            sendButton.SetOnClickListener(this);
            msgListView.TranscriptMode = TranscriptMode.AlwaysScroll;
            msgListView.StackFromBottom = true;
            chatlist = new List<ChatMessage>();
            chatAdapter = new ChatAdapter(this, chatlist);
            msgListView.SetAdapter(chatAdapter);
        }

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.sendMessageButton:
                    sendTextMessage(v);
                    break;
            }
        }

        public void sendTextMessage(View v)
        {
            String message = msg_edittext.EditableText.ToString();
            if (!message.Equals("", StringComparison.InvariantCultureIgnoreCase))
            {
                ChatMessage chatMessage = new ChatMessage(user1, user2,
                        message, "" + random.Next(1000), true);
                chatMessage.setMsgID();
                chatMessage.body = message;
                chatMessage.Date = CommonMethods.getCurrentDate();
                chatMessage.Time = CommonMethods.getCurrentTime();
                msg_edittext.Text = "";
                chatAdapter.add(chatMessage);
                chatAdapter.NotifyDataSetChanged();
            }
        }
    }
}

