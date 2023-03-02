using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApp.Interface;

namespace ChatApp.Model
{
    internal class User : IUser
    {
        //private List<IChat> userChats;

        public void SendMessageToChat(IChat chat, string message)
        {
            throw new NotImplementedException();
        }

        public void SubscribeToChat(IChat chat)
        {
            chat.AddSubscriber(this);
        }

        public void ReceiveMessageFromChat(string message)
        {
            throw new NotImplementedException();
        }
    }
}
