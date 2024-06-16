using GymApp.Views;
using GymApp.ViewModels;

namespace GymApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		// MainPage = new AppShell();
        MainPage = new LoginPage();
	}

    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void OnResume()
    {
        base.OnResume();
    }

    protected override void OnSleep()
    {
        base.OnSleep();
    }
}