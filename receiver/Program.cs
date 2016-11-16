using System;
using GeekseatBus;
using ConsoleApplication1.Messages.Events;

namespace ConsoleApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(var bus = new GsBus()) {
                bus.Connect();
                Console.WriteLine("connected");
                Console.ReadLine();
            }
        }
    }
}
