namespace ServiceLocatorPattern
{
    public interface IAnalyticsService
    {
        public void SendEvent(string eventName);
    }
}