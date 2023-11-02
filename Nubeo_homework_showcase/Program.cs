using Nubeo_MessageService;
using Nubeo_MessageService.ConcreteServices;

Console.WriteLine("Hello, Nubeo!");

SetCredentials();
void SetCredentials()
{
    Console.WriteLine("Your Twilio account sid:");
    string accountSid = Console.ReadLine();

    Console.WriteLine("Your Twilio authToken:");
    string authToken = Console.ReadLine();

    SendMessage(accountSid, authToken);
}



void SendMessage(string accountSid, string authToken)
{
    Console.WriteLine("Your Twilio phone number:");
    string senderNumber = Console.ReadLine();

    Console.WriteLine("Recipient's phone number:");
    string recipientNumber = Console.ReadLine();

    Console.WriteLine("Your message:");
    string message = Console.ReadLine();

    TwilioSms twilioSms = new TwilioSms(accountSid, authToken);
    MessageService messageService = new MessageService(twilioSms);

    string result = messageService.SendMessage(senderNumber, recipientNumber, messageService.CreateMessage(message));
    Console.WriteLine(result);
    Console.WriteLine("________________________________________________");

    if (result == "Authenticate")
        SetCredentials();
    else  
        SendMessage(accountSid, authToken);
}
