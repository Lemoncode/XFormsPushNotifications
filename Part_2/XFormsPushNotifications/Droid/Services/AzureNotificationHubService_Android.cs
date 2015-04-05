using System;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
using XFormsPushNotifications.Droid.Services.Real;
using System.Threading.Tasks;

[assembly: Dependency(typeof(AzureNotificationHubService_Android))]
namespace XFormsPushNotifications.Droid.Services.Real
{
	public class AzureNotificationHubService_Android:IAzureNotificationHubService
	{
		private MobileServiceClient _mobileServiceClient;
		private Push _push;
		public string CurrentDeviceId { get; private set; }

		public AzureNotificationHubService_Android ()
		{
			_mobileServiceClient = new MobileServiceClient (Helpers.Keys.AzureMobileService_URL, Helpers.Keys.AzureMobileService_KEY); 
			_push = _mobileServiceClient.GetPush ();
		}

		public async Task UnregisterNativeAsync ()
		{
			await _push.UnregisterNativeAsync ();
		}

		public async Task RegisterNativeAsync (string deviceId)
		{
			CurrentDeviceId = deviceId;

			await _push.RegisterNativeAsync (deviceId);
		}
	}
}

