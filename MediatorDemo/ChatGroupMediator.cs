namespace MediatorDemo
{
    public class ChatGroupMediator : IChatGroupMediator
    {
        private List<User> users = new List<User>();

        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public void SendMsg(string msg, User user)
        {
            foreach (var u in users)
            {
                if (u != user)
                {
                    u.Receive(msg);
                }
            }
        }
    }
}
