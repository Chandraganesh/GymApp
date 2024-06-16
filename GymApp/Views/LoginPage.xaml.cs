namespace GymApp.Views;
using GymApp.BL;
using GymApp.ViewModels;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	async void LoginButton_Clicked(object sender, EventArgs args)
	{
		LoginViewModel vm = BindingContext as LoginViewModel;
		LoginBL loginBL = new LoginBL();
		
        if(loginBL.Login(vm.UserName, vm.Password))
        {
			((App)Application.Current).MainPage = new AppShell();
        }
        else
        {
            vm.ErrorText = "Invlid Login. Please try again";
        }
	}
}