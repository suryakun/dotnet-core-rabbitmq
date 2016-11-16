using System;
using ConsoleApplication1.Messages.Events;
using GeekseatBus;

namespace ConsoleApplication2.Messages.Handlers {
    public class MyEventHandler : IGsHandler<MyEvent> 
    {
        public void Handle(MyEvent me)
        {
            Console.WriteLine(me);
            Console.WriteLine($"Event {me.GetType().FullName} ({me.ToJsonString()}) handled");
        }
    }
}