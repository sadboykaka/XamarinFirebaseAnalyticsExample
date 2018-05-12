using Xamarin.Forms;
using FAnalyticsExample.iOS;
using Firebase.Analytics;
using Foundation;

[assembly: Dependency(typeof(AnalyticsService))]
namespace FAnalyticsExample.iOS
{
	public class AnalyticsService:IAnalytics
    {   
		public void Event(string id, string name, string content)
		{         
			NSString[] keys = { ParameterNamesConstants.ItemId, ParameterNamesConstants.ItemName,ParameterNamesConstants.ContentType };
			NSObject[] values = { new NSString(id), new NSString(name), new NSString(content) };
            var parameters = NSDictionary<NSString, NSObject>.FromObjectsAndKeys(keys, values, keys.Length);
            Analytics.LogEvent(EventNamesConstants.SelectContent, parameters);
		}

		public void Page(string p, string c)
		{
			Analytics.SetScreenNameAndClass(p, c);
		}
	}
}
