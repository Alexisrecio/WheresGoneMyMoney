using Android.App;
using Android.Content.PM;
using Android.OS;

namespace WheresGoneMyMoney.Droid
{
    [Activity(Label = "WheresGoneMyMoney", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        #region Singleton

        private static MainActivity _instance;

        public static MainActivity GetInstance()
        {
            return _instance ?? (_instance = new MainActivity());
        }


        #endregion
        protected override void OnCreate(Bundle bundle)
        {
            _instance = this;
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

