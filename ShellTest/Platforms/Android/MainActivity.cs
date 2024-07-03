using Android.App;
using Android.Content.PM;
using Android.OS;
using Thread = System.Threading.Thread;

namespace ShellTest;

[Activity(Theme=  "@style/Maui.SplashTheme",MainLauncher = true,
    LaunchMode = LaunchMode.SingleTask,
    ResizeableActivity = true,
    Exported = true,
    ScreenOrientation = ScreenOrientation.Portrait,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode| ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize| ConfigChanges.Density)]

public class MainActivity : MauiAppCompatActivity
{
    private App App;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Platform.Init(this, savedInstanceState);

            App = new App();
        }
}