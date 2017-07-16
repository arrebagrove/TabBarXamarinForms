using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace TabbarForms.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			UITabBar.Appearance.BarTintColor = UIColor.FromRGB (33,150,243);
			UITabBar.Appearance.TintColor = UIColor.White;
			UIProgressView.Appearance.TintColor = UIColor.FromRGB (33,150,243);

			LoadApplication (new App ());



			return base.FinishedLaunching (app, options);
		}
	}
}
