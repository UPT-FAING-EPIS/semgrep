namespace Notifications.Domain
{
    public abstract class AbstractMessage
    {
        protected IMessageSender _messageSender;
        public abstract string SendMessage(string Message);        
    }
}