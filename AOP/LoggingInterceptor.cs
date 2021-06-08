using Castle.DynamicProxy;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOP
{
    public class LoggingInterceptor : IInterceptor
    {
        private readonly ILogger<LoggingInterceptor> _logger;
        public LoggingInterceptor(ILogger<LoggingInterceptor> logger)
        {
            _logger = logger;
        }
        public void Intercept(IInvocation invocation)
        {
            _logger.LogDebug($"Call the method {invocation.TargetType}.{invocation.Method.Name}");
            invocation.Proceed();
        }
    }
}
