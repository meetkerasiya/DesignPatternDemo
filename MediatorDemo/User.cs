namespace MediatorDemo
{
    public abstract class User
    {
        protected ChatGroupMediator mediator;
        protected string name;

        public User(ChatGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string message);

        public abstract void Receive(string message);
    }
}
