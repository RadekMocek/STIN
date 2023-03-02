using ChatApp.Interface;
using ChatApp.Model;

namespace ChatApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChat chat1 = new Chat();

            IUser user1 = new User("Alice");
            user1.SubscribeToChat(chat1);

            IUser user2 = new User("Bob");
            user2.SendMessageToChat(chat1, new StringMessage("Anyone?"));
        }
    }
}
