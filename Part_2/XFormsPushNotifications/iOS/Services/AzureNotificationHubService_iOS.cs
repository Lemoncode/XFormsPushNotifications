using System;
using Xamarin.Forms;
using XFormsPushNotifications.iOS.Services.Real;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

[assembly: Dependency(typeof(AzureNotificationHubService_iOS))]
namespace XFormsPushNotifications.iOS.Services.Real
{
	public class AzureNotificationHubService_iOS:IAzureNotificationHubService
	{
		private MobileServiceClient _mobileServiceClient;
		private Push _push;

		public string CurrentDeviceId { get; private set; }

		public AzureNotificationHubService_iOS ()
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


