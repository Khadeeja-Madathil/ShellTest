using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTest;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute("firstpage", typeof(FirstPage));
        Routing.RegisterRoute("secondpage", typeof(SecondPage));
        Routing.RegisterRoute("thirdpage", typeof(ThirdPage));
        Routing.RegisterRoute("Home", typeof(MainPage));
    }
}