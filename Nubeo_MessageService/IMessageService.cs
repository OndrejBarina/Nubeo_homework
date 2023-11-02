namespace Nubeo_MessageService
{
    public interface IMessageService
    {
        string SendMessage(string sender, string recipient, Message message);

    }
}
