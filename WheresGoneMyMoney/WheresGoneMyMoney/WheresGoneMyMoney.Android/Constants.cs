using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WheresGoneMyMoney.Droid
{
    public static class Constants
    {
        public const string SenderId = "814018443052";
        public const string ListenConnectionString = "Endpoint=sb://psmhub.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=VRZxkd15WUJsWXWmkt0UySRsCg6K/9ZSytBIdsV7Grs=";
        public const string NotificationHubName = "MainNotification";
    }
}