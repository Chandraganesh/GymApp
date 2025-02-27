using CommunityToolkit.Mvvm.ComponentModel;
using GymApp.DAL;
using GymApp.Models;
using System.Collections.ObjectModel;

namespace GymApp.ViewModels;

public class MembersViewModel : ObservableObject
{
    public GymAppDataBase dataBase;
    public MembersViewModel(GymAppDataBase _dataBase)
    {
        dataBase = _dataBase;
        Task.Run(async () => await GetAllMembers()).ConfigureAwait(false);
    }

    protected async Task GetAllMembers()
    {
        try
        {
            var membersList = await dataBase.GetAllMembersAsync();
            Members = new ObservableCollection<Member>(membersList);
        }
        catch(Exception ex)
        {

        }
    }

    private ObservableCollection<Member> _members;
    public ObservableCollection<Member> Members
    {
        get => _members;
        set => SetProperty(ref _members, value);
    }

    private Member _selectedMember;
    public Member SelectedMember
    {
        get => _selectedMember;
        set => SetProperty(ref _selectedMember, value);
    }
}