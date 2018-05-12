using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace FAnalyticsExample
{
	public partial class EventsPage : ContentPage
    {      
        public EventsPage()
        {
			InitializeComponent();

			On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
		}

		protected override void OnAppearing()
		{
            DependencyService.Get<IAnalytics>().Page("Events page", ToString());

			base.OnAppearing();
		}

		public void Event1_Clicked(object sender, EventArgs e)
        {
			DependencyService.Get<IAnalytics>().Event("1", "Event 1", "button");
        }

        public void Event2_Clicked(object sender, EventArgs e)
		{
			DependencyService.Get<IAnalytics>().Event("2", "Event 2", "button");
        }

        public void Event3_Clicked(object sender, EventArgs e)
		{
			DependencyService.Get<IAnalytics>().Event("3", "Event 3", "button");
        }
    }
}
