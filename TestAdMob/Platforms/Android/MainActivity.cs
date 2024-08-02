using Android.App;
using Android.Content.PM;
using Android.OS;
using Plugin.MauiMTAdmob;
namespace TestAdMob;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        var appId = "APP_ID"; // Replace app id

        CrossMauiMTAdmob.Current.Init(this, appId);

    }
}
