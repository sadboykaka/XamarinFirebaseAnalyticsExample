using Xamarin.Forms;
using FAnalyticsExample.Droid;
using Firebase.Analytics;
using Android.OS;

[assembly: Dependency(typeof(AnalyticsService))]
namespace FAnalyticsExample.Droid
{
	public class AnalyticsService : IAnalytics
	{
		private static FirebaseAnalytics firebaseAnalytics;

		public AnalyticsService()
		{
			firebaseAnalytics = FirebaseAnalytics.GetInstance(Android.App.Application.Context);
		}

		public void Event(string id, string name, string content)
		{         
            var bundle = new Bundle();
            bundle.PutString(FirebaseAnalytics.Param.ItemId, id);
            bundle.PutString(FirebaseAnalytics.Param.ItemName, name);
			bundle.PutString(FirebaseAnalytics.Param.ContentType, content);

			firebaseAnalytics.LogEvent(FirebaseAnalytics.Event.SelectContent, bundle);
		}

		public void Page(string p, string c)
		{
			firebaseAnalytics.SetCurrentScreen(null, p, c);
		}
	}
}
