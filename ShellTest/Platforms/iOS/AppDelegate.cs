using Foundation;

namespace ShellTest;

[Register("AppDelegate")]
    public partial class AppDelegate : Microsoft.Maui.MauiUIApplicationDelegate
    {
        private App App;
        
        protected override MauiApp CreateMauiApp()
        {
            return MauiProgram.CreateMauiApp();
        }
    }