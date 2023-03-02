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

        public void SendMessageToSubscribers(IMessage message)
        {
            foreach (IUser subscriber in subscribers) {
                subscriber.ReceiveMessageFromChat(message);
            }
        }
    }
}
