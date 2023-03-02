using ChatApp.Interface;

namespace ChatApp.Model
{
    internal readonly struct StringMessage : IMessage
    {
        private readonly string content;

        public StringMessage(string content)
        {
            this.content = content;
        }

        public string GetMessageString() => content;
    }
}
