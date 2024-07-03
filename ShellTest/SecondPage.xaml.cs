using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTest;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();

        var state = Shell.Current.CurrentState;
    }
    
    private async void Button_OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("thirdpage");
    }
}