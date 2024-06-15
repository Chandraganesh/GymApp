using GymApp.ViewModels;

namespace GymApp;

public partial class App : Application
{
    public static LoginViewModel loginViewModel { get; private set; }
	public App()
	{
		InitializeComponent();
		// MainPage = new AppShell();
        loginViewModel = new();
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