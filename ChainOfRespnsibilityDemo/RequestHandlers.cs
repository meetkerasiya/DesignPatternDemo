namespace ChainOfRespnsibilityDemo
{
    public abstract class RequestHandler
    {
        protected RequestHandler successor;

        public void SetSuccessor(RequestHandler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int number_of_requests);
    }

    public class Handler : RequestHandler
    {
        public override void HandleRequest(int number_of_requests)
        {
            if(number_of_requests>=0 && number_of_requests<=10)
            {
                Console.WriteLine($"{this.GetType().Name} handled the {number_of_requests} requests");

            }
            else if(successor!=null)
            {
                successor.HandleRequest(number_of_requests);
            }
        }
    }

    public class BiggerHandler : RequestHandler
    {
        public override void HandleRequest(int number_of_requests)
        {
            if(number_of_requests>=11 && number_of_requests<=20)
            {
                Console.WriteLine($"{this.GetType().Name} handled the {number_of_requests} requests");

            }
            else if(successor!=null)
            {
                successor.HandleRequest(number_of_requests);
            }
        }
    }

    public class BiggestHandler : RequestHandler
    {
        public override void HandleRequest(int number_of_requests)
        {
            if(number_of_requests>=21 && number_of_requests<=30)
            {
                Console.WriteLine($"{this.GetType().Name} handled the {number_of_requests} requests");

            }
            else if(successor!=null)
            {
                successor.HandleRequest(number_of_requests);
            }
        }
    }



}
