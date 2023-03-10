namespace DesignPatternDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Singleton obj1 = Singleton.GetObject();
            obj1.TestMethod();

            Singleton obj2 = Singleton.GetObject();
            obj2.TestMethod();


        }
    }


}