using Android.App;
using Android.Runtime;
using Android.OS;

namespace ShellTest;

[Application]
public class MainApplication : MauiApplication, MauiApplication.IActivityLifecycleCallbacks
{
    
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    
    public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
    {
        RegisterActivityLifecycleCallbacks(this);
    }

    public void OnActivityDestroyed(Activity activity)
    {
        UnregisterActivityLifecycleCallbacks(this);
    }

    public void OnActivityPaused(Activity activity)
    {

    }

    public void OnActivityResumed(Activity activity)
    {
    }

    public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
    {

    }

    public void OnActivityStarted(Activity activity)
    {
    }

    public void OnActivityStopped(Activity activity)
    {
        
    }
}