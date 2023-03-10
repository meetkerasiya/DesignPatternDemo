namespace DesignPatternDemo
{
    sealed class Singleton
    {
        private Singleton()
        {

        }

        public static Singleton getinstance = null;
        public static Singleton GetObject()
        {
            if(getinstance==null)
            {
                return new Singleton();

            }
            return getinstance;
        }

        public void TestMethod()
        {
            Console.WriteLine("This is a test method");
        }
    }
}
