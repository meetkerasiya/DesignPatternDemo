namespace MediatorDemo
{
    public class ChatUser : User
    {
        public ChatUser(ChatGroupMediator mediator,string name) : base(mediator,name)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine(this.name+ ": Sending Message:" + message);
            mediator.SendMsg(message, this);
        }
        public override void Receive(string message)
        {
            Console.WriteLine(this.name + ": Received Message:" + message);
        }
    }
}
