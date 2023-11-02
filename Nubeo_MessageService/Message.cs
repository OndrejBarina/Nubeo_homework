namespace Nubeo_MessageService
{
    public class Message
    {
        public string Body { get; set; }

        public Message(string body)
        {
            Body = body;
        }
    }
}
