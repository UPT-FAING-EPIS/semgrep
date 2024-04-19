namespace Notifications.Domain
{
    public class EmailMessageSender : IMessageSender
    {
        public string SendMessage(string Message)
        {
            return "'" + Message + "'   : This Message has been sent using Email";
        }
    }
}