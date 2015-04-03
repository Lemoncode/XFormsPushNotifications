using System;
using PushNotification.Plugin;
using PushNotification.Plugin.Abstractions;
using System.Collections.Generic;

namespace XFormsPushNotifications
{
	public class CrossPushNotificationListener:IPushNotificationListener
	{
		public void OnMessage (IDictionary<string, object> Parameters, DeviceType deviceType)
		{
			
		}

		public void OnRegistered (string Token, DeviceType deviceType)
		{
			
		}

		public void OnUnregistered (DeviceType deviceType)
		{
			
		}

		public void OnError (string message, DeviceType deviceType)
		{
			
		}
	}
}

