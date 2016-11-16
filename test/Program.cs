using System;
using GeekseatBus;
using ConsoleApplication1.Messages.Events;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(var bus = new GsBus()) {
                if (!bus.IsConnected) bus.Connect();
                Console.WriteLine("Client started");
                MyEvent me = new MyEvent{message = "Hai doc"};
                bus.Publish(me);
                Console.ReadLine();
            }
        }
    }
}
