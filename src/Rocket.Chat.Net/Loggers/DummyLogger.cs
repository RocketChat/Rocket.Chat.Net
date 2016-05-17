namespace Rocket.Chat.Net.Loggers
{
    using Rocket.Chat.Net.Interfaces;

    public class DummyLogger : ILogger
    {
        public void Debug(string message)
        {
        }

        public void Info(string message)
        {
        }

        public void Warn(string message)
        {
        }

        public void Error(string message)
        {
        }

        public void Fatal(string message)
        {
        }
    }
}