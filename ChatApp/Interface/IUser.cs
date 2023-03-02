namespace ChatApp.Interface
{
    internal interface IUser
    {
        void SubscribeToChat(IChat chat);
        void SendMessageToChat(IChat chat, IMessage message);
        void ReceiveMessageFromChat(IMessage message);
    }
}
