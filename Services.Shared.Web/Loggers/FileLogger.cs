using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace Services.Shared.Web.Loggers
{
    public class FileLogger : ILogger
    {
        private static object _lock = new object();

        private readonly string _filePath;
        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return default;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (formatter != null)
            {
                lock (_lock)
                {
                    var log = $"[{logLevel.ToString()}] - [{DateTime.UtcNow}]: {formatter(state, exception)}{Environment.NewLine}";

                    File.AppendAllText(_filePath, log);
                }
            }
        }
    }
}
