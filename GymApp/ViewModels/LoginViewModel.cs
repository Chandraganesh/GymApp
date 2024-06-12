using System.ComponentModel;

namespace GymApp.ViewModels;

public class LoginViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private string _userName;
    public string UserName
    {
        get
        {
            return _userName;
        }
        set
        {
            _userName = value;
            OnPropertyChanged(nameof(UserName));
        }
    }

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}