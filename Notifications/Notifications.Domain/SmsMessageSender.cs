namespace Notifications.Domain
{
    public class SmsMessageSender : IMessageSender
    {
        public string SendMessage(string Message)
        {
            return "'" + Message + "' : This Message has been sent using SMS";
        }
    }
}