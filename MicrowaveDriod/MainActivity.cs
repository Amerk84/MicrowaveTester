using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace MicrowaveDriod
{
	[Activity (Label = "MicrowaveDriod", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}

		protected void StartTest()
		{
			lblResult.Text="";


			System.Threading.Thread.Sleep(10000);

			if(Reachability.IsHostReachable("http://google.com")) {
				lblResult.Text = "Crap!  Your microwave has leaks.";
			}
			else
			{
				lblResult.Text = "Yay!  Your microwave is all good.";
			}

		}
	}
}


