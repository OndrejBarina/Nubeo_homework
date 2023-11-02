namespace Nubeo_MessageService
{
    public class MessageService
    {
        private IMessageService messageService;

        public MessageService(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        public Message CreateMessage(string messageBody)
        {
            return new Message(messageBody);
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="recipient"></param>
        /// <param name="message"></param>
        /// <returns>Result of action.</returns>
        public string SendMessage(string sender, string recipient, Message message)
        {
            return messageService.SendMessage(sender, recipient, message);
        }         
    }
}
