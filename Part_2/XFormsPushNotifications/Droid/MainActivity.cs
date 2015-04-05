using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using PushNotification.Plugin;
using XFormsPushNotifications.Helpers;

namespace XFormsPushNotifications.Droid
{
	[Activity (Label = "XFormsPushNotifications.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			CrossPushNotification.Initialize<CrossPushNotificationListener>(Keys.GOOGLE_APIs_ID);

			LoadApplication (new App ());
		}
	}
}

