namespace GymApp;
using GymApp.BL;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	async void LoginButton_Clicked(object sender, EventArgs args)
	{
		LoginBL loginBL = new LoginBL();
        if(loginBL.Login(App.loginViewModel.UserName, App.loginViewModel.Password))
        {
			((App)Application.Current).MainPage = new AppShell();
        }
        else
        {
            App.loginViewModel.ErrorText = "Invlid Login. Please try again";
        }
	}
}