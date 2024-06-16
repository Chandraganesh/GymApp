using CommunityToolkit.Mvvm.ComponentModel;
using GymApp.BL;
using System.Windows.Input;

namespace GymApp.ViewModels;
public class LoginViewModel : ObservableObject
{
    public ICommand LoginCommand{ get; private set; }
    private string _userName;
    public string UserName
    {
        get => _userName;
        set
        {
            SetProperty(ref _userName, value);
            EnableLoginButton();
        }
    }

    private string _password;
    public string Password
    {
        get => _password;
        set
        {
            SetProperty(ref _password, value);
            EnableLoginButton();
        }
    }

    private bool _isLoginButtonEnabled = true;
    public bool IsLoginButtonEnabled
    {
        get => _isLoginButtonEnabled;
        set => SetProperty(ref _isLoginButtonEnabled, value);
    }

    private string _errorText;
    public string ErrorText
    {
        get => _errorText;
        set => SetProperty(ref _errorText, value);
    }
    public LoginViewModel()
    {
        LoginCommand = new Command(Login);
    }

    private void Login()
    {
        LoginBL loginBL = new LoginBL();
        if(loginBL.Login(UserName, Password))
        {
            //Navigate to the home page
            
        }
        else
        {
            ErrorText = "Invlid Login. Please try again";
        }
    }

    private void EnableLoginButton()
    {
        ErrorText = string.Empty;
        if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrWhiteSpace(UserName) &&
         !string.IsNullOrEmpty(Password) && !string.IsNullOrWhiteSpace(Password))
        {
            IsLoginButtonEnabled = true;
        }
        else
        {
            IsLoginButtonEnabled = false;
         }
    }
}