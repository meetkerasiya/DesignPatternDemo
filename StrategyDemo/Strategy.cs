namespace StrategyDemo
{
    public abstract class Strategy
    {
        Strategy _next;
        public Strategy Append(Strategy next)
        {
            if(_next == null)
            {
                _next = next;
            }
            else
            {
                _next.Append(next);
            }
            return this;
        }

        public abstract void Do(int n);

        protected void Next(int n)
        {
            _next?.Do(n);
        }
    }

    public class Log : Strategy
    {
        public override void Do(int n)
        {
            Console.WriteLine($"Logging a number {n}");
            Next(n);
        }
    }
    public class Add : Strategy
    {
        int _num;
        public Add(int num)
        {
            _num = num;
        }

        public override void Do(int n)
        {
            Console.WriteLine($"Adding {_num} to {n}");
            int sum = n += _num;
            Console.WriteLine($"Sum={sum}");
            Next(sum);
        }
    }

    public class Transaction : Strategy
    {

        public override void Do(int n)
        {
            Console.WriteLine("Starting transaction");
            Next(n);
            Console.WriteLine("Finishing transaction");
        }
    }
}
