using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApp.Interface;

namespace ChatApp.Model
{
    internal class Chat : IChat
    {
        private readonly List<IUser> subscribers;

        public Chat()
        {
            subscribers = new List<IUser>();
        }

        public void AddSubscriber(IUser subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void SendMessageToSubscribers(string message)
        {
            foreach (IUser subscriber in subscribers) {
                subscriber.ReceiveMessageFromChat(message);
            }
        }
    }
}
