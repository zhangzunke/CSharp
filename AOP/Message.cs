using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AOP
{
    public interface IMessage
    {
        void Send(string content);
        void Receive(string content);
    }

    public class Message : IMessage
    {
        public void Receive(string content)
        {
            Console.WriteLine($"Receive Email: {content}");
        }

        public void Send(string content)
        {
            Console.WriteLine($"Send Email: {content}");
        }
    }

    public class LogDispatchProxy : DispatchProxy
    { 
        public object TargetClass { get; set; }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            Write("Before");
            var result = targetMethod.Invoke(TargetClass, args);
            Write("After");
            return result;
        }

        private void Write(string content)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
            Console.ResetColor();
        }
    }
}
