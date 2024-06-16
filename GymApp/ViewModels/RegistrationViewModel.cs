using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using GymApp.Enums;
using GymApp.Models;

namespace GymApp.ViewModels;

public class RegistrationViewModel : ObservableObject
{
    public RegistrationViewModel()
    {
        SubmitCommand = new Command(Submit);
    }

    public ICommand SubmitCommand { get; private set; }
    private string _firstName;
    public string FirstName
    {
        get => _firstName;
        set => SetProperty(ref _firstName, value);
    }

    private string _lastName;
    public string LastName
    {
        get => _lastName;
        set => SetProperty(ref _lastName, value);
    }

    private string _address;
    public string Address
    {
        get => _address;
        set => SetProperty(ref _address, value);
    }

    public Sex Male { get; private set; } = Sex.Male;
    public Sex Female { get; private set; } = Sex.Female;
    private Sex _sex = Sex.Male;
    public Sex Sex
    {
        get => _sex;
        set => SetProperty(ref _sex, value);
    }

    private int _age;
    public int Age
    {
        get => _age;
        set => SetProperty(ref _age, value);
    }

    private string _contactNumber;
    public string ContactNumber
    {
        get => _contactNumber;
        set => SetProperty(ref _contactNumber, value);
    }

    private string _nationality;
    public string Nationality
    {
        get => _nationality;
        set => SetProperty(ref _nationality, value);
    }

    public Plan OneMonthPlan { get; private set; } = Plan.OneMonth;
    public Plan ThreeMonthsPlan { get; private set; } = Plan.ThreeMonths;
    public Plan SixMonthsPlan { get; private set; } = Plan.SixMonths;
    public Plan OneYearPlan { get; private set; } = Plan.OneYear;
    private Plan _selectedPlan = Plan.ThreeMonths;
    public Plan SelectedPlan
    {
        get => _selectedPlan;
        set {
            SetProperty(ref _selectedPlan, value);
            switch(value)
            {
                case Plan.OneMonth: PlanPrice = 20;
                break;
                case Plan.ThreeMonths: PlanPrice = 40;
                break;
                case Plan.SixMonths: PlanPrice = 60;
                break;
                case Plan.OneYear: PlanPrice = 80;
                break;
            }
            DiscountedPrice = PlanPrice;
        }
    }

    private int _planPrice;
    public int PlanPrice
    {
        get => _planPrice;
        set => SetProperty(ref _planPrice, value);
    }

    private int _discountedPrice;
    public int DiscountedPrice
    {
        get => _discountedPrice;
        set => SetProperty(ref _discountedPrice, value);
    }

    private List<int> _freeMonthsOptions = new List<int> { 1, 2, 3};
    public List<int> FreeMonthsOptions
    {
        get => _freeMonthsOptions;
        set => SetProperty(ref _freeMonthsOptions, value);
    }

    private int _freeMonths;
    public int FreeMonths
    {
        get => _freeMonths;
        set => SetProperty(ref _freeMonths, value);
    }

    private void Submit()
    {
        //Do later : Check form completion and show confirmation preview page
        bool isDiscounted = DiscountedPrice < PlanPrice;

        Member member = new Member{
            FirstName = FirstName,
            LastName = LastName,
            Address = Address,
            Sex = Sex,
            Age = Age,
            ContactNumber = ContactNumber,
            Nationality = Nationality,
            Plan = SelectedPlan,
            Price = PlanPrice,
            IsDiscounted = isDiscounted,
            GivenPrice = isDiscounted ? DiscountedPrice : PlanPrice,
            FreeMonths = FreeMonths,
            SignedDate = DateTime.Now,
            ExpiryDate = DateTime.Now.AddMonths(MembershipDurationInMonths(SelectedPlan, FreeMonths))
        };

        //Save/update member to DB
    }

    private int MembershipDurationInMonths(Plan selectedPlan, int freeMonths)
    {
        int numberOfMonths = 0;
        switch(selectedPlan)
        {
            case Plan.OneMonth: numberOfMonths += 1;
            break;
            case Plan.ThreeMonths: numberOfMonths += 3;
            break;
            case Plan.SixMonths: numberOfMonths += 6;
            break;
            case Plan.OneYear: numberOfMonths += 12;
            break;
        }
        numberOfMonths += FreeMonths;

        return numberOfMonths;
    }
}