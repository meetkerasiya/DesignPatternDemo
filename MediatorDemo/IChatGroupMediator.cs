namespace MediatorDemo
{
    public interface IChatGroupMediator
    {
        void RegisterUser(User user);
        void SendMsg(string msg, User user);
    }
}