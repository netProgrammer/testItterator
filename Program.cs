using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAggregate aggregate = new ConcreteAggregate();
        }
    }
}
