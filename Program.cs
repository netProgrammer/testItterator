using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAggregate aggregate = new ConcreteAggregate();
            aggregate[0] = "A";
            aggregate[1] = "B";
            aggregate[2] = "C";
            aggregate[3] = "D";

            IItterator iter = aggregate.CreateItterator();

            Console.Write("First Element is ");
            Console.WriteLine(iter.First());

            Console.WriteLine("Iteration");
            Console.WriteLine(iter.CurrentItem());
            while (!iter.IsDone())
            {
                iter.Next();
                Console.WriteLine(iter.CurrentItem());
                
            }            
        }
    }
}
