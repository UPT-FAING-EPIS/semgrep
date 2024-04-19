namespace Notifications.Domain
{
    public class ShortMessage: AbstractMessage
    {
        public const string LARGE_ERROR_MESSAGE = "Unable to send the message as length > 10 characters";
        public ShortMessage(IMessageSender messageSender)
        {
            this._messageSender = messageSender;
        }
        public override string SendMessage(string Message)
        {
            if (Message.Length <= 25)
                return _messageSender.SendMessage(Message);
            else
                throw new ArgumentException(LARGE_ERROR_MESSAGE);
        }
    }
}