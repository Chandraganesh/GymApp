using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace GymApp;

public class HomeViewModel : ObservableObject
{
    public ICommand ItemSelectionCommand { get; private set; }
    public HomeViewModel()
    {
        ItemSelectionCommand = new Command<string>(SelectMenuItem);
    }

    private async void SelectMenuItem(string menuItemName)
    {
        switch(menuItemName)
        {
            case "NEWREGISTRATION":
                await Shell.Current.GoToAsync("registration");
            break;
            case "MEMBERS":
                await Shell.Current.GoToAsync("members");
            break;
            case "REPORTS":
                await Shell.Current.GoToAsync("reports");
            break;
            case "ENQUIRIES":
                await Shell.Current.GoToAsync("enquiries");
            break;
        }
    }
}