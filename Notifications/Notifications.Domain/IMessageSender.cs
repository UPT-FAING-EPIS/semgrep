namespace Notifications.Domain
{
    public interface IMessageSender
    {
        string SendMessage(string Message);
    }
}