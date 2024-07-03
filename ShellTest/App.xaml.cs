
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace ShellTest;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            
            var state = Shell.Current.CurrentState;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }