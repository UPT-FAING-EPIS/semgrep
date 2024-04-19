namespace Notifications.Domain
{
    public class LongMessage: AbstractMessage
    {
        public LongMessage(IMessageSender messageSender)
        {
            this._messageSender = messageSender;
        }
        public override string SendMessage(string Message)
        {
           return _messageSender.SendMessage(Message);
        }
    }
}