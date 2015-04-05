using System;
using System.Threading.Tasks;

namespace XFormsPushNotifications
{
	public interface IAzureNotificationHubService
	{
		Task RegisterNativeAsync(string deviceId);
		Task UnregisterNativeAsync ();
	}
}

