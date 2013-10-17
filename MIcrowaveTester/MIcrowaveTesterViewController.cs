using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Threading;

namespace MIcrowaveTester
{
	public partial class MIcrowaveTesterViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public MIcrowaveTesterViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		#region View lifecycle
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			actTesting.Hidden = true;
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}
		#endregion
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			if (UserInterfaceIdiomIsPhone) {
				return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
			} else {
				return true;
			}
		}

		
		partial void btnTest_TouchUpInside (UIButton sender)
		{
			actTesting.Hidden = false;

			actTesting.StartAnimating ();
			lblResult.Text="";
			ThreadPool.QueueUserWorkItem (o => TestMicrowave ());
			actTesting.StopAnimating ();
		}

		private void TestMicrowave()
		{


			Thread.Sleep(10000);

			string sResult = "";
			if(Reachability.IsHostReachable("http://google.com")) 
			{
				sResult = "Crap!  Your microwave has leaks.";
			}
			else
			{
				sResult = "Yay!  Your microwave is all good.";
			}

			InvokeOnMainThread (() => lblResult.Text = sResult);
		}
	}
}

