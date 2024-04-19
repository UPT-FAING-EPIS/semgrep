using Notifications.Domain;
using NUnit.Framework;

namespace Notifications.Domain.Tests
{
    public class MessageTests
    {
        [Test]
        public void GivenLongMessage_WhenSend_ThenEmailIsTriggered()
        {
            string Message = "Este es un mensaje bien pero bien largoooooooooooooooooooooooo.";
            AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
            var confirm = longMessage.SendMessage(Message);
            Assert.IsTrue(!string.IsNullOrEmpty(confirm));
            Assert.IsTrue(confirm.Contains(Message));
        }
        [Test]
        public void GivenShortMessage_WhenSend_ThenSMSIsTriggered()
        {
            string Message = "Este es un mensaje corto.";
            AbstractMessage shortMessage = new ShortMessage(new SmsMessageSender());
            var confirm = shortMessage.SendMessage(Message);
            Assert.IsTrue(!string.IsNullOrEmpty(confirm));
            Assert.IsTrue(confirm.Contains(Message));
        }
        [Test]
        public void GivenLargeMessage_WhenSendinSMS_ThenOccursException()
        {
            string Message = "Este es un mensaje largooooooooooooooooo.";
            AbstractMessage shortMessage = new ShortMessage(new SmsMessageSender());
            Assert.Throws<ArgumentException>(
                () => shortMessage.SendMessage(Message)
                , ShortMessage.LARGE_ERROR_MESSAGE);
        }
    }
}