namespace Nubeo_MessageService.AbstractServices
{
    public abstract class SmsService : IMessageService
    {
        public abstract string SendMessage(string senderPhone, string recipientPhone, Message message);

    }
}
