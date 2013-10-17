// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace MIcrowaveTester
{
	[Register ("MIcrowaveTesterViewController")]
	partial class MIcrowaveTesterViewController
	{
		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIActivityIndicatorView actTesting { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnTest { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblResult { get; set; }

		[Action ("btnTest_TouchUpInside:")]
		partial void btnTest_TouchUpInside (MonoTouch.UIKit.UIButton sender);

		[Action ("UIButton9_TouchUpInside:")]
		partial void UIButton9_TouchUpInside (MonoTouch.UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btnTest != null) {
				btnTest.Dispose ();
				btnTest = null;
			}

			if (lblResult != null) {
				lblResult.Dispose ();
				lblResult = null;
			}

			if (actTesting != null) {
				actTesting.Dispose ();
				actTesting = null;
			}
		}
	}
}
