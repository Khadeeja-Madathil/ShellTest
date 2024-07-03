using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTest;

public partial class ThirdPage : ContentPage
{
    public ThirdPage()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Home");
    }
}