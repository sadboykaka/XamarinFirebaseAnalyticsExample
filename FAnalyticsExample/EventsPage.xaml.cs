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

        public void Event1_Clicked(object sender, EventArgs e)
        {
			
        }

        public void Event2_Clicked(object sender, EventArgs e)
        {
			
        }

        public void Event3_Clicked(object sender, EventArgs e)
        {
			
        }
    }
}
