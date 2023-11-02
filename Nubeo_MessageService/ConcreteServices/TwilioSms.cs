using Nubeo_MessageService.AbstractServices;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Nubeo_MessageService.ConcreteServices
{
    public class TwilioSms : SmsService
    {
        public TwilioSms(string accountSID, string authToken)
        {
            TwilioClient.Init(accountSID, authToken);
        }

        public override string SendMessage(string senderPhone, string recipientPhone, Message message)
        {
            try
            {
                MessageResource.Create(
                    from: new Twilio.Types.PhoneNumber(senderPhone),
                    body: message.Body,
                    to: new Twilio.Types.PhoneNumber(recipientPhone)
                );
                return "Message was successfully sent.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
