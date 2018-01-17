﻿
using Gcm.Client;
using Xamarin.Forms;
using Android.Util;
using WheresGoneMyMoney.Interfaces;


[assembly: Dependency(typeof(WheresGoneMyMoney.Droid.RegistrationDevice))]
namespace WheresGoneMyMoney.Droid
{
    public class RegistrationDevice : IRegisterDevice
    {
        #region Methods
        public void RegisterDevice()
        {
            var mainActivity = MainActivity.GetInstance();
            GcmClient.CheckDevice(mainActivity);
            GcmClient.CheckManifest(mainActivity);

            Log.Info("MainActivity", "Registering...");
            GcmClient.Register(mainActivity, Constants.SenderId);
        }
        #endregion
    }
}