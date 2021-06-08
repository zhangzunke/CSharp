using System;
using System.Reflection;

namespace AOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageProxy = DispatchProxy.Create<IMessage, LogDispatchProxy>();
            ((LogDispatchProxy)messageProxy).TargetClass = new Message();
            messageProxy.Send("Hello");
            messageProxy.Receive("World");
            var proxy = DispatchProxy.Create<IFoobar, FoobarProxy<IFoobar>>();
            ((FoobarProxy<IFoobar>)proxy).Target = new Foobar();
            proxy.Invoke();
            Console.WriteLine("Hello World!");
        }
    }
}
