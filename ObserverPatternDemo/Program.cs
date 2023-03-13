using ObserverPatternDemo;

INotifyObserver obj1 = new MailNotify();
INotifyObserver obj2 = new SMSNotify();

Notifier notifier = new Notifier();
notifier.AddService(obj1);
notifier.AddService(obj2);
notifier.ExeciteNotifier();