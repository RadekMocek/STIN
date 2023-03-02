using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Interface
{
    internal interface IChat
    {
        void AddSubscriber(IUser subscriber);
        void SendMessageToSubscribers(string message);
    }
}
