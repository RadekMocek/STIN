using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Interface
{
    internal interface IUser
    {
        void SubscribeToChat(IChat chat);
        void SendMessageToChat(IChat chat, string message);
        void ReceiveMessageFromChat(string message);
    }
}
