using System.Collections;

namespace ObserverPatternDemo
{
    class Notifier
    {
        public ArrayList notificationList=new ArrayList();

        public void AddService(INotifyObserver obj)
        {
            notificationList.Add(obj);
        }

        public void RemoveService(INotifyObserver obj)
        {
            notificationList.Remove(obj);
        }

        public void ExeciteNotifier()
        {
            foreach (INotifyObserver obj in notificationList)
            {
                obj.Notify();
            }
        }
    }
}
