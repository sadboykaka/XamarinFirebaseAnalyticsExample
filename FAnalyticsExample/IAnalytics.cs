namespace FAnalyticsExample
{
    public interface IAnalytics
    {
		void Event(string id, string name, string content);
		void Page(string p, string c);
    }
}
