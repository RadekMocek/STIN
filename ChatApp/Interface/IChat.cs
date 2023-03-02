namespace ChatApp.Interface
{
    internal interface IChat
    {
        void AddSubscriber(IUser subscriber);
        void SendMessageToSubscribers(IMessage message);
    }
}
