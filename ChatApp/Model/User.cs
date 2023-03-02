using ChatApp.Interface;

namespace ChatApp.Model
{
    internal class User : IUser
    {
        private readonly string name;

        public User(string name)
        {
            this.name = name;
        }

        public void SendMessageToChat(IChat chat, IMessage message)
        {
            chat.SendMessageToSubscribers(message);
        }

        public void SubscribeToChat(IChat chat)
        {
            chat.AddSubscriber(this);
        }

        public void ReceiveMessageFromChat(IMessage message)
        {
            Console.WriteLine($"User with name \"{name}\" received message: \"{message.GetMessageString()}\".");
        }
    }
}
