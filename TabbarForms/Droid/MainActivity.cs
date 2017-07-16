using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Graphics;

namespace TabbarForms.Droid
{
	[Activity (Label = "TabbarForms.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity , TabLayout.IOnTabSelectedListener
	{
		public void OnTabReselected (TabLayout.Tab tab)
		{
			throw new NotImplementedException ();
		}

		public void OnTabSelected (TabLayout.Tab tab)
		{
			tab.Icon.SetColorFilter (Color.White, PorterDuff.Mode.SrcIn);
		}

		public void OnTabUnselected (TabLayout.Tab tab)
		{
			tab.Icon.SetColorFilter (Color.Gray, PorterDuff.Mode.SrcIn);
		}

		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			//LayoutInflater view = (LayoutInflater)this.GetSystemService(LayoutInflaterService);
			//LayoutInflater view1 = view.Inflate(Resource.Layout.Toolbar);
			////TabLayout tabLayout = (Android.Support.Design.Widget.TabLayout)FindViewById (Resource.Id.sliding_tabs);
			//tabLayout.SetOnTabSelectedListener(this);

			base.OnCreate (bundle);



			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}
	}
}
