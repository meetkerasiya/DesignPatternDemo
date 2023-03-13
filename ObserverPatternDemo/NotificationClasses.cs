namespace ObserverPatternDemo
{
    interface INotifyObserver
    {
        void Notify();
    }

    class MailNotify : INotifyObserver
    {
        public void Notify()
        {
            Console.WriteLine("Notify through Mail.");
        }
    }

    class EventNotify : INotifyObserver
    {
        public void Notify()
        {
            Console.WriteLine("Notify through Event.");

        }
    }

    class SMSNotify : INotifyObserver
    {
        public void Notify()
        {
            Console.WriteLine("Notify through SMS.");

        }
    }
}
