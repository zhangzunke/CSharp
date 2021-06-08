using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AOP
{
    public static class Indicator
    {
        public static bool Injected { get; set; }
    }

    public interface IFoobar
    {
        int Invoke();
    }

    public class Foobar : IFoobar
    {
        public int Invoke() => 1;
    }

    public class FoobarProxy<T> : DispatchProxy
    {
        public T Target { get; set; }
        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            Indicator.Injected = true;
            return targetMethod.Invoke(Target, args);
        }
    }

    public class FoobarProxy : IFoobar
    {
        private readonly IFoobar _target;
        public FoobarProxy(IFoobar target) => _target = target;
        public int Invoke()
        {
            Indicator.Injected = true;
            return _target.Invoke();
        }
    }
}
