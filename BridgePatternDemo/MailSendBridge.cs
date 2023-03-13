namespace BridgePatternDemo
{
    public class MailSendBridge
    {
        public void SendFrom(IMail mail)
        {
            mail.Send();
        }
    }
}
