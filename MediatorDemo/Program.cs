
using MediatorDemo;

ChatGroupMediator mediator = new();

User Meet = new ChatUser(mediator, "Meet");
User Krupal = new ChatUser(mediator, "Krupal");
User Jay = new ChatUser(mediator, "Jay");
User Mitesh = new ChatUser(mediator, "Mitesh");
User Bhayo = new ChatUser(mediator, "Bhayo");

mediator.RegisterUser(Meet);
mediator.RegisterUser(Krupal);
mediator.RegisterUser(Jay);
mediator.RegisterUser(Mitesh);
mediator.RegisterUser(Bhayo);

Meet.Send("Minna!!! arigato gozaimasu!!");
Console.WriteLine();

Mitesh.Send("What?");
